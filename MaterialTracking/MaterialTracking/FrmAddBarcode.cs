using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronBarCode;


namespace BarcodOlusturma
{
    public partial class FrmAddBarcode : Form
    {
        Image picture;
        public FrmAddBarcode()
        {
            InitializeComponent();
        }

        private void btn_barcode_Click(object sender, EventArgs e)
        {        
            pictureBox1.Visible = true;
            pictureBox1.BackColor = FrmAddBarcode.DefaultBackColor;
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            var barcodeImage = barcode.Draw(txt_barcode.Text, 70);

            var resultImage = new Bitmap(barcodeImage.Width , barcodeImage.Height + 25); 

            using (var graphics = Graphics.FromImage(resultImage))
            using (var font = new Font("Monaco", 12))
            using (var brush = new SolidBrush(Color.Black))
            using (var format = new StringFormat()
            {
                Alignment = StringAlignment.Center, 
                LineAlignment = StringAlignment.Far
            })
            {
                graphics.Clear(Color.White);
                graphics.DrawImage(barcodeImage, 0, 0);
                graphics.DrawString(txt_barcode.Text, font, brush, resultImage.Width / 2, resultImage.Height, format);
            }        
            pictureBox1.Image = resultImage;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            maskedTextBox1.Visible = true;
            btn_printBarcod.Visible = true;
        }      
        private void btn_barcodeOku_Click(object sender, EventArgs e)
        {
            FrmMenu form = new FrmMenu();
            form.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {        
            for (int i = 1; i <= int.Parse(maskedTextBox1.Text)  ; i++)
            {
                if (i == 1)
                    e.Graphics.DrawImage(pictureBox1.Image, 60, pictureBox1.Height);
                if (i == 2)
                    e.Graphics.DrawImage(pictureBox1.Image, 360, pictureBox1.Height);
                if (i == 3)
                    e.Graphics.DrawImage(pictureBox1.Image, 650, pictureBox1.Height);
                if (i == 4)
                    e.Graphics.DrawImage(pictureBox1.Image, 60, pictureBox1.Height + 200);
                if (i == 5)
                    e.Graphics.DrawImage(pictureBox1.Image, 360, pictureBox1.Height + 200);
                if (i == 6)
                    e.Graphics.DrawImage(pictureBox1.Image, 650, pictureBox1.Height + 200);
                if (i == 7)
                    e.Graphics.DrawImage(pictureBox1.Image, 60, pictureBox1.Height + 400);
                if (i == 8)
                    e.Graphics.DrawImage(pictureBox1.Image, 360, pictureBox1.Height + 400);
                if (i == 9)
                    e.Graphics.DrawImage(pictureBox1.Image, 650, pictureBox1.Height + 400);
                if (i == 10)
                    e.Graphics.DrawImage(pictureBox1.Image, 60, pictureBox1.Height + 600);
                if (i == 11)
                    e.Graphics.DrawImage(pictureBox1.Image, 360, pictureBox1.Height + 600);
                if (i == 12)
                    e.Graphics.DrawImage(pictureBox1.Image, 650, pictureBox1.Height + 600);
                if (i == 13)
                    e.Graphics.DrawImage(pictureBox1.Image, 60, pictureBox1.Height + 800);
                if (i == 14)
                    e.Graphics.DrawImage(pictureBox1.Image, 360, pictureBox1.Height + 800);
                if (i == 15)
                    e.Graphics.DrawImage(pictureBox1.Image, 650, pictureBox1.Height + 800);
            }         
        }

        private void btn_printBarcod_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıktı verilsin mi ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                printDocument1.Print(); 
        }
        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(maskedTextBox1.Text) > 15)
            {
                MessageBox.Show("Bir sayfada en fazla 15 adet barkod bulunabilir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskedTextBox1.Text = "15";
            }
            if (int.Parse(maskedTextBox1.Text) == 0)
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBox1.Text = "0";
            }
        }
    }
}
