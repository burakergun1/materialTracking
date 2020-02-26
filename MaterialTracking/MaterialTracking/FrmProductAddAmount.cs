using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using AForge;
using ZXing;
using System.Data.SqlClient;

namespace BarcodOlusturma
{ 
    public partial class FrmProductAddAmount : Form
    {
        VideoCaptureDevice videoCaptureDevice;
        FilterInfoCollection filterInfoCollection;
        Connection con = new Connection();

        Boolean measure = false;
        public FrmProductAddAmount()
        {
            InitializeComponent();
        }

        private void FrmProductAddAmount_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cmb_measure.SelectedIndex = 0;
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                cboCamera.Items.Add(device.Name);
            cboCamera.SelectedIndex = 0;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Open();
            cmd.CommandText = "SELECT productRegister.product_barcod AS 'Barkod',productRegister.product_name AS 'Ürün Adı', " +
                "CAST(SUM(product_amount) as DECIMAL(15,3)) AS 'Miktar (Gram/MiliLitre)', productRegister.product_date AS 'Ürünün Eklenme Tarihi' " +
                "FROM productAdd " +
                "INNER JOIN productRegister ON productAdd.product_barcod = productRegister.product_barcod " +
                "GROUP BY productRegister.product_barcod , productRegister.product_name,productRegister.product_date " +
                "ORDER BY productRegister.product_date DESC";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.Dispose();
            con.Close();

           // cmb_productName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con.Open();
            cmd2.CommandText = "SELECT product_name FROM productRegister " +
                "INNER JOIN productAdd ON productAdd.product_barcod = productRegister.product_barcod " +
                "GROUP BY product_name " +
                "HAVING COUNT(productAdd.product_barcod) >= 1";
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                data.Add(dr[0].ToString());
                cmb_productName.Items.Add(dr[0].ToString());
            }
            cmb_productName.AutoCompleteCustomSource = data;
            cmd2.Dispose();
            con.Close();

            ToolTip Aciklama = new ToolTip();
            Aciklama.ToolTipTitle = "Dikkat!";
            Aciklama.ToolTipIcon = ToolTipIcon.Warning;
            Aciklama.IsBalloon = true;

            Aciklama.SetToolTip(cmb_measure, "Girdiğiniz miktarlar Gram/MiliLitre olarak kaydediliyor.");
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            FrmMenu form = new FrmMenu();
            form.Show();
            this.Hide();
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void btn_camOpen_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            timer1.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void FrmProductAddAmount_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image != null)
                {
                    BarcodeReader barcode = new BarcodeReader();
                    Result result = barcode.Decode((Bitmap)pictureBox1.Image);

                    if (result != null)
                    {
                        txt_barcode.Text = result.ToString();
                        timer1.Stop();
                        pictureBox1.Visible = false;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Barkod okutulurken bir hata meydana geldi. Lütfen tekrar deneyin."
                   , "Uyarı Paneli", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_barcode_TextChanged(object sender, EventArgs e)
        {
            String info = "";
            if (txt_barcode.Text != null)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.Open();
                cmd.CommandText = "SELECT productRegister.product_barcod, product_name, SUM(product_amount) FROM productRegister " +
                    "INNER JOIN productAdd ON productRegister.product_barcod = productAdd.product_barcod " +
                    "WHERE productRegister.product_barcod = '"+txt_barcode.Text+"' " +
                    "GROUP BY productRegister.product_barcod, product_name";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_barcode.Text = dr[0].ToString();
                    info = dr[1].ToString();                       
                }
                cmd.Dispose();
                con.Close();
                if (info == "")
                {
                    MessageBox.Show("HATA! "+txt_barcode.Text + " barkoduna sahip herhangi bir ürün kaydı bulunmamaktadır. " +
                        "Lütfen tekrar deneyiniz ya da "+txt_barcode.Text+" barkoda sahip bir ürün ekleyiniz."
                    , "Uyarı Paneli", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cmb_productName.SelectedItem = info;
            }        
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string info;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_barcode.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            info = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmb_productName.SelectedItem = info;
        }

        private void btn_productAdd_Click(object sender, EventArgs e)
        {      
            if (measure == true)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con.Open();
                    cmd.CommandText = "INSERT INTO productAdd (productAdd.product_barcod,product_amount,product_date) " +
                        "values (@p1,@p2,@p3) " +
                        "SELECT productRegister.product_barcod, productAdd.product_amount, productAdd.product_date " +
                        "FROM productRegister " +
                        "INNER JOIN productAdd ON productAdd.product_barcod = productRegister.product_barcod ";
                    cmd.Parameters.AddWithValue("@p1", txt_barcode.Text);
                    MessageBox.Show(txt_newValue.Text);
                    txt_newValue.Text = String.Format("{0:0.000}", txt_newValue.Text);
                    MessageBox.Show(txt_newValue.Text);
                    cmd.Parameters.AddWithValue("@p2", float.Parse(txt_newValue.Text));
                    cmd.Parameters.AddWithValue("@p3", dateTime_productdate.Value);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();

                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = con.Open();
                    cmd2.CommandText = "SELECT productRegister.product_barcod AS 'Barkod',productRegister.product_name AS 'Ürün Adı', " +
                        "CAST(SUM(product_amount) as DECIMAL(15,3)) AS 'Miktar', productRegister.product_date AS 'Ürünün Eklenme Tarihi' " +
                        "FROM productAdd " +
                        "INNER JOIN productRegister ON productAdd.product_barcod = productRegister.product_barcod " +
                        "GROUP BY productRegister.product_barcod , productRegister.product_name,productRegister.product_date " +
                        "ORDER BY productRegister.product_date DESC";
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    cmd2.Dispose();
                    con.Close();

                    MessageBox.Show(cmb_productName.SelectedItem.ToString() + " üründen " + txt_newValue.Text + " "+cmb_measure.SelectedItem+ " başarılı bir şekilde eklendi."
                       , "Kayıt Paneli", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_value.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Ürün eklenirken bir hata oluştu. Lütfen tekrar deneyiniz."
                        , "Uyarı Paneli", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (measure == false)
            {
                MessageBox.Show("Lütfen girdiğiniz miktarın türünü belirleyiniz.");
                cmb_measure.Focus();
            }
        }

        private void btn_productHistory_Click(object sender, EventArgs e)
        {
            FrmProductAddHistory form = new FrmProductAddHistory();
            form.Show();
            this.Hide();
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void cmb_measure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_measure.SelectedIndex != -1 && cmb_measure.SelectedIndex != 0)
            {
                measure = true;
                if (txt_value.Text != "")
                {
                    if (cmb_measure.SelectedItem == "Gram")
                        txt_newValue.Text = (float.Parse(txt_value.Text) / 1).ToString();
                    if (cmb_measure.SelectedItem == "MiliGram")
                        txt_newValue.Text = (float.Parse(txt_value.Text) / 1000).ToString();
                    if (cmb_measure.SelectedItem == "MikroLitre")
                        txt_newValue.Text = (float.Parse(txt_value.Text) / 1000).ToString();
                    if (cmb_measure.SelectedItem == "MiliLitre")
                        txt_newValue.Text = (float.Parse(txt_value.Text) / 1).ToString();
                    if (cmb_measure.SelectedItem == "Litre")
                        txt_newValue.Text = (float.Parse(txt_value.Text) * 1000).ToString();
                }
                if (txt_value.Text == "")
                {
                    MessageBox.Show("Lütfen ilk eklenilecek miktarı giriniz."
                   , "Bilgi Paneli", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_measure.SelectedIndex = 0;
                }
            }
        }
    }
}
