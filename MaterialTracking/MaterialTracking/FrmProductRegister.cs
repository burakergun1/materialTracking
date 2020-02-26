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
using AForge.Video.DirectShow;
using ZXing;

namespace BarcodOlusturma
{
    public partial class FrmProductRegister : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        Connection con = new Connection();

        public FrmProductRegister()
        {
            InitializeComponent();
        }
        
        private void btn_barcodeEkle_Click(object sender, EventArgs e)
        {
            FrmAddBarcode form = new FrmAddBarcode();
            form.Show();
            this.Hide();
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void FrmReadBarcode_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                cboCamera.Items.Add(device.Name);
            cboCamera.SelectedIndex = 0;
        }
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void btn_camOpen_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            timer1.Start();
        }

        private void FrmReadBarcode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcode = new BarcodeReader();
                Result result = barcode.Decode((Bitmap)pictureBox1.Image);
             
                if (result != null)
                {
                    txt_barcode.Text = result.ToString();  
                    timer1.Stop();                 
                }
            }
        }

        private void btn_productRegister_Click(object sender, EventArgs e)
        {
            int countBarcod = 0;
            int countName = 0;
            try
            {
                if (string.IsNullOrWhiteSpace(txt_barcode.Text) || string.IsNullOrWhiteSpace(txt_product.Text))
                {
                    lbl_message.Visible = true;
                    lbl_message.ForeColor = Color.Red;
                    this.lbl_message.Location = new System.Drawing.Point(248, 385);
                    lbl_message.Text = "Ürün adı boş olamaz. Lütfen tekrar deneyiniz.";
                }
                else
                {
                    SqlCommand cmd3 = new SqlCommand();
                    cmd3.Connection = con.Open();
                    cmd3.CommandText = "SELECT COUNT(*) FROM productRegister WHERE product_barcod = '" + txt_barcode.Text + "'";
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                        countBarcod = int.Parse(dr3[0].ToString());
                    cmd3.Dispose();
                    con.Close();

                    SqlCommand cmd4 = new SqlCommand();
                    cmd4.Connection = con.Open();
                    cmd4.CommandText = "SELECT COUNT(*) FROM productRegister WHERE product_name = '" + txt_product.Text + "'";
                    SqlDataReader dr4 = cmd4.ExecuteReader();
                    while (dr4.Read())
                        countName = int.Parse(dr4[0].ToString());
                    cmd4.Dispose();
                    con.Close();

                    MessageBox.Show(countBarcod.ToString() + " "+ countName.ToString());
                    if (countBarcod == 1 && countName == 1)
                    {
                        this.lbl_message.Location = new System.Drawing.Point(148, 385);
                        lbl_message.Visible = true;
                        lbl_message.ForeColor = Color.Red;
                        lbl_message.Text = txt_barcode.Text + " barkoda ve " +
                            "" + txt_product.Text + " ismine nsahip ürün kaydın vardır.\nLütfen başkan bir barkod numarası ve isim deneyiniz.";
                    }
                    else if (countBarcod == 1)
                    {
                        this.lbl_message.Location = new System.Drawing.Point(188, 385);
                        lbl_message.Visible = true;
                        lbl_message.ForeColor = Color.Red;
                        lbl_message.Text = txt_barcode.Text+" barkoda sahip ürün kaydı vardır.\nLütfen başka bir barkod numarası deneyiniz.";
                    }
                    else if (countName == 1)
                    {
                        this.lbl_message.Location = new System.Drawing.Point(218, 385);
                        lbl_message.Visible = true;
                        lbl_message.ForeColor = Color.Red;
                        lbl_message.Text = txt_product.Text + " ismine sahip ürün kaydı vardır.\nLütfen başka bir isim deneyiniz.";
                    }
                    else
                    {
                        Boolean kontrol = false;
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con.Open();
                        cmd.CommandText = "INSERT INTO productRegister (product_barcod, product_name, product_date)" +
                            " values (@p1,@p2,@p3)";
                        cmd.Parameters.AddWithValue("@p1", txt_barcode.Text);
                        cmd.Parameters.AddWithValue("@p2", txt_product.Text);
                        cmd.Parameters.AddWithValue("@p3", dateTime_productdate.Value);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();

                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = con.Open();
                        cmd2.CommandText = "INSERT INTO productAdd (product_barcod, product_date)" +
                            " values (@p1,@p2)";
                        cmd2.Parameters.AddWithValue("@p1", txt_barcode.Text);
                        cmd2.Parameters.AddWithValue("@p2", dateTime_productdate.Value);
                        cmd2.ExecuteNonQuery();
                        cmd2.Dispose();
                        con.Close();

                        this.lbl_message.Location = new System.Drawing.Point(248, 385);
                        lbl_message.Visible = true;
                        lbl_message.ForeColor = Color.Green;
                        lbl_message.Text = txt_barcode.Text + " barkoda sahip " + txt_product.Text + " ürünü\n başarılı bir şekilde eklendi.";

                        kontrol = true;
                        if (kontrol)
                        {
                            txt_barcode.Text = "";
                            txt_product.Text = "";
                            timer1.Start();
                            //videoCaptureDevice.Stop();
                            //Application.Restart();
                        }
                    }         
                }
            }
            catch (Exception)
            {
                this.lbl_message.Location = new System.Drawing.Point(248, 385);
                lbl_message.Visible = true;
                lbl_message.ForeColor = Color.Red;
                lbl_message.Text = "Ürün eklenirken bir hata oluştu.\nLütfen tekrar deneyiniz.";  
            }
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
    }
}
