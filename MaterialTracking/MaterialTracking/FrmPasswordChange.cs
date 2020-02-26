using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BarcodOlusturma
{
    public partial class FrmPasswordChange : Form
    {
        private System.Windows.Forms.Timer tmr;
        public FrmPasswordChange()
        {
            InitializeComponent();
            txt_oldpassword.PasswordChar = '•';
            txt_newpassword.PasswordChar = '•';
            txt_newpassword2.PasswordChar = '•';
        }
        Connection con = new Connection();

        String username = null;
        String password = null;
        int live = 3;
        private void btn_changepassword_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Open();
            cmd.CommandText = "SELECT username FROM Admin " +
                "WHERE username = '" + txt_username.Text + "' AND password = '"+txt_oldpassword.Text+"'";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                username = dr[0].ToString();
            }
            con.Close();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con.Open();
            cmd2.CommandText = "SELECT password FROM Admin " +
                "WHERE username = '" + txt_username.Text + "' AND password = '" + txt_oldpassword.Text + "'";
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                password = dr2[0].ToString();
            }
            cmd2.Dispose();
            con.Close();

            if (txt_username.Text == "" && txt_oldpassword.Text != "")
            {
                lbl_message.Visible = true;
                lbl_message.ForeColor = Color.Red;
                this.lbl_message.Location = new System.Drawing.Point(179, 299);
                lbl_message.Text = "Kullanıcı adınızı girmediniz.\nLütfen kullanıcı adınızı giriniz.";
              
            }
            if (txt_username.Text != "" && txt_oldpassword.Text == "")
            {
                this.lbl_message.Location = new System.Drawing.Point(201, 299);
                lbl_message.Visible = true;
                lbl_message.ForeColor = Color.Red;
                lbl_message.Text = "Şifrenizi girmediniz.\nLütfen şifrenizi giriniz.";    
            }
            
            if (live > 0)
            {
                if (username != txt_username.Text && password != txt_oldpassword.Text)
                {
                    this.btn_changepassword.Location = new System.Drawing.Point(257, 337);
                    live--;
                    lbl_message.Visible = true;
                    lbl_message.ForeColor = Color.Red;
                    this.lbl_message.Location = new System.Drawing.Point(160, 289);
                    lbl_message.Text = "Kullanıcı adınızı ya da şifrenizi yanlış\ngirdiniz." +
                        "" + live.ToString() + " hakkınız kaldı."+
                        "\nLütfen tekrar deneyiniz.";
                    
                }
                if (username == txt_username.Text && password == txt_oldpassword.Text)
                {
                    if (string.IsNullOrWhiteSpace(txt_newpassword.Text) || string.IsNullOrWhiteSpace(txt_newpassword2.Text))
                    {
                        lbl_message.Visible = true;
                        lbl_message.ForeColor = Color.Red;
                        lbl_message.Text = "Boşluk kullanmayınız.\nLütfen tekrar deneyiniz.";
                        return;
                    }
                    else if (txt_newpassword.Text == txt_newpassword2.Text && txt_oldpassword.Text != txt_newpassword.Text && txt_oldpassword.Text != txt_newpassword2.Text)
                    {
                        SqlCommand cmd3 = new SqlCommand();
                        cmd3.Connection = con.Open();
                        cmd3.CommandText = "UPDATE Admin SET password = '" + txt_newpassword.Text + "' " +
                            "WHERE username = '" + txt_username.Text + "'";
                        cmd3.ExecuteNonQuery();
                        cmd3.Dispose();
                        con.Close();
                        this.lbl_message.Location = new System.Drawing.Point(175, 289);
                        lbl_message.Visible = true;
                        lbl_message.ForeColor = Color.Green;
                        lbl_message.Text = "Kullanıcı adı : " + txt_username.Text + "\n Şifre başarıyla güncellendi.\nGiriş Ekranına Yönlendiriliyorsunuz.";
                        tmr = new System.Windows.Forms.Timer();
                        tmr.Tick += delegate
                        {
                            FrmLogin form = new FrmLogin();
                            form.Show();
                            this.Hide();
                            tmr.Stop();
                        };
                        tmr.Interval = (int)TimeSpan.FromSeconds(3).TotalMilliseconds;
                        tmr.Start();
                    }
                    if (txt_newpassword.Text != txt_newpassword2.Text)
                    {
                        this.lbl_message.Location = new System.Drawing.Point(201, 299);
                        lbl_message.Visible = true;
                        lbl_message.ForeColor = Color.Red;
                        lbl_message.Text = "Girdiğiniz şifreler farklıdır. \nLütfen tekrar deneyiniz.";
                    }
                    if (txt_oldpassword.Text == txt_newpassword.Text || txt_newpassword2.Text == txt_oldpassword.Text)
                    {
                        this.lbl_message.Location = new System.Drawing.Point(161, 289);
                        lbl_message.Visible = true;
                        lbl_message.ForeColor = Color.Red;
                        lbl_message.Text = "Mevcut şifreniz ile aynı şifre girdiniz. \nLütfen tekrar deneyiniz.";
                    }  
                }
            }
            if (live == 0)
            {
                MessageBox.Show("Üst üste 3 kere geçersiz kullanıcı adı veya \nşifre girdiğiniz için uygulama kapanıyor. \nLütfen tekrar deneyin."
                    , "Bilgi Paneli", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}
