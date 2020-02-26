using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace BarcodOlusturma
{
    public partial class FrmProductAddHistory : Form
    {
        public FrmProductAddHistory()
        {
            InitializeComponent();
        }

        VideoCaptureDevice videoCaptureDevice;
        FilterInfoCollection filterInfoCollection;
        Connection con = new Connection();

        Boolean barcode = false;
        Boolean name = false;
        Boolean date = false;

        void infoDataGrid()
        {
            try
            {
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = con.Open();
                cmd2.CommandText = "SELECT productRegister.product_barcod AS 'Barkod', product_name AS 'Ürün Adı', " +
                    "CAST((product_amount) as DECIMAL(15,3)) AS 'Miktar (Gram/MiliLitre)', productAdd.product_date AS 'Tarih' " +
                    "FROM productRegister INNER JOIN productAdd ON productRegister.product_barcod = productAdd.product_barcod " +
                    "WHERE product_amount != 0 AND product_amount > 0 " +
                    "ORDER BY productAdd.product_date DESC";
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cmd2.Dispose();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen tekrar deneyin."
                     , "Uyarı Paneli", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmProductHistory_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                cboCamera.Items.Add(device.Name);
            cboCamera.SelectedIndex = 0;

            cmb_productName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.Open();
                cmd.CommandText = "SELECT product_name FROM productRegister";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    data.Add(dr[0].ToString());
                    cmb_productName.Items.Add(dr[0].ToString());
                }
                cmb_productName.AutoCompleteCustomSource = data;
                cmd.Dispose();
                con.Close();

                infoDataGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen tekrar deneyin."
                    , "Uyarı Paneli", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void btn_productDetailSearch_Click(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Parse(dateTimePicker1.Value.ToShortDateString());
            DateTime dt2 = DateTime.Parse(dateTimePicker2.Value.ToShortDateString());
            string date1 = dt1.ToString("yyyy-MM-dd");
            string date2 = dt2.ToString("yyyy-MM-dd");
            try
            {
                if (checkBox2.Checked == true && checkBox1.Checked == false)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con.Open();
                    cmd.CommandText = "SELECT productRegister.product_barcod AS 'Barkod', product_name AS 'Ürün Adı', " +
                        "CAST((product_amount) as DECIMAL(15,3)) AS 'Miktar', productAdd.product_date AS 'Tarih' " +
                        "FROM productRegister " +
                        "INNER JOIN productAdd ON productRegister.product_barcod = productAdd.product_barcod " +
                        "WHERE product_amount != 0 AND productAdd.product_date " +
                        "BETWEEN @p1 AND @p2 " +
                        "ORDER BY productAdd.product_date DESC";
                    cmd.Parameters.AddWithValue("@p1", date1);
                    cmd.Parameters.AddWithValue("@p2", date2);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    cmd.Dispose();
                    con.Close();
                    MessageBox.Show(date1 + " ile " + date2 + " tarihleri arasındaki ürünler başarıyla sıralandı."
                   , "Bilgi Paneli", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (checkBox1.Checked == true && checkBox2.Checked == false)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con.Open();
                    cmd.CommandText = "SELECT productRegister.product_barcod AS 'Barkod', product_name AS 'Ürün Adı', " +
                        "CAST((product_amount) as DECIMAL(15,3)) AS 'Miktar', productAdd.product_date AS 'Tarih' " +
                        "FROM productRegister " +
                        "INNER JOIN productAdd ON productRegister.product_barcod = productAdd.product_barcod " +
                        "WHERE product_amount != 0 AND productRegister.product_name = @p1 AND productRegister.product_barcod = @p2 " +
                        "ORDER BY productAdd.product_date DESC";
                    cmd.Parameters.AddWithValue("@p1", cmb_productName.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@p2", txt_barcode.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    cmd.Dispose();
                    con.Close();
                    MessageBox.Show(cmb_productName.SelectedItem.ToString() + " adlı ürünün ekleme geçmişi başarıyla gösterildi."
                  , "Bilgi Paneli", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (checkBox1.Checked == true && checkBox2.Checked == true)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con.Open();
                    cmd.CommandText = "SELECT productRegister.product_barcod AS 'Barkod', product_name AS 'Ürün Adı', " +
                        "CAST((product_amount) as DECIMAL(15,3)) AS 'Miktar', productAdd.product_date AS 'Tarih' " +
                        "FROM productRegister " +
                        "INNER JOIN productAdd ON productRegister.product_barcod = productAdd.product_barcod " +
                        "WHERE product_amount != 0 AND productRegister.product_name = @p1 AND productRegister.product_barcod = @p2 " +
                        "AND productAdd.product_date BETWEEN @p3 AND @p4 " +
                        "ORDER BY productAdd.product_date DESC";
                    cmd.Parameters.AddWithValue("@p1", cmb_productName.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@p2", txt_barcode.Text);
                    cmd.Parameters.AddWithValue("@p3", date1);
                    cmd.Parameters.AddWithValue("@p4", date2);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    cmd.Dispose();
                    con.Close();
                    MessageBox.Show(date1 + " ile " + date2 + " tarihleri arasındaki "+cmb_productName.SelectedItem.ToString() + " adlı ürünün ekleme geçmişi başarıyla gösterildi."
                  , "Bilgi Paneli", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ürün veya ürünler sıralanırken bir hata meydana geldi. Lütfen tekrar deneyin."
                   , "Uyarı Paneli", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cmb_productName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (name == true)
            {
                txt_barcode.Text = "";
                if (cmb_productName.SelectedIndex != -1)
                {
                    try
                    {
                        txt_barcode.Text = "";
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con.Open();
                        cmd.CommandText = "SELECT productRegister.product_barcod FROM productRegister " +
                                "INNER JOIN productAdd ON productAdd.product_barcod = productRegister.product_barcod " +
                                "WHERE product_name = '" + cmb_productName.SelectedItem.ToString() + "'";
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                            txt_barcode.Text = dr[0].ToString();
                        cmd.Dispose();
                        con.Close();
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Ürün seçerken bir hata meydana geldi. Lütfen tekrar deneyin."
                   , "Uyarı Paneli", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }            
            }
        }

        private void txt_barcode_TextChanged(object sender, EventArgs e)
        {
            if (barcode == true)
            {
                if (txt_barcode.Text != null)
                {
                    try
                    {
                        int index;
                        SqlCommand cmd3 = new SqlCommand();
                        cmd3.Connection = con.Open();
                        cmd3.CommandText = "SELECT productRegister.product_name FROM productRegister " +
                            "INNER JOIN productAdd ON productAdd.product_barcod = productRegister.product_barcod " +
                            "WHERE productRegister.product_barcod = '" + txt_barcode.Text + "'" +
                            "GROUP BY productRegister.product_name " +
                            "HAVING COUNT(productRegister.product_barcod) >= 1";
                        SqlDataReader dr3 = cmd3.ExecuteReader();
                        while (dr3.Read())
                        {
                            index = cmb_productName.FindString(dr3[0].ToString());
                            cmb_productName.SelectedIndex = index;
                        }
                        cmd3.Dispose();
                        con.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Barkod okutulurken bir hata meydana geldi. Lütfen tekrar deneyin."
                   , "Uyarı Paneli", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                date = true;
                btn_productDetailSearch.Visible = true;
            }
            if (checkBox2.Checked == false)
            {
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                date = false;
                infoDataGrid();
                btn_productDetailSearch.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
               
                MessageBoxManager.Yes = "BARKOD";
                MessageBoxManager.No = "ÜRÜN ADI";
                MessageBoxManager.Register();
                DialogResult result = MessageBox.Show("Ürününüzü barkod kullanarak mı, ürün adı kullanarak mı aramak istersiniz ?" +
                    " Barkod kullanarak arama yapmak için BARKOD'a basınız, Ürün adı kullanarak arama yapmak için ÜRÜN ADI'na basınız."
                       , "Bilgi Paneli", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                lbl_productName.Visible = true;
                label1.Visible = true;
                cmb_productName.Visible = true;
                txt_barcode.Visible = true;
                btn_productDetailSearch.Visible = true;
                if (result == DialogResult.Yes)
                {
                    barcode = true;
                    cmb_productName.Enabled = false;
                    cboCamera.Visible = true;
                    label4.Visible = true;
                    btn_camOpen.Visible = true;
                    cmb_productName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                }
                if (result == DialogResult.No)
                {
                    cmb_productName.Enabled = true;
                    name = true;
                    txt_barcode.ReadOnly = true;
                }
                MessageBoxManager.Unregister();
            }
            if (checkBox1.Checked == false)
            {
                lbl_productName.Visible = false;
                label1.Visible = false;
                cmb_productName.Visible = false;
                txt_barcode.Visible = false;
                txt_barcode.ReadOnly = false;
                cboCamera.Visible = false;
                btn_camOpen.Visible = false;
                label4.Visible = false;
                pictureBox1.Visible = false;
                if (videoCaptureDevice != null)
                {
                    if (videoCaptureDevice.IsRunning)
                        videoCaptureDevice.Stop();
                }
                name = false;
                barcode = false;
                infoDataGrid();
                cmb_productName.SelectedIndex = -1;
                txt_barcode.Text = "";
                btn_productDetailSearch.Visible = false;
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

        private void btn_productAddMenu_Click(object sender, EventArgs e)
        {
            FrmProductAddAmount form = new FrmProductAddAmount();
            form.Show();
            this.Hide();
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void FrmProductHistory_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
