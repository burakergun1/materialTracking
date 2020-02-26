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

namespace BarcodOlusturma
{

    public partial class FrmLogin : Form
    {
        private System.Windows.Forms.Timer tmr;
        public FrmLogin()
        {
            InitializeComponent();
            txt_password.PasswordChar = '•';
        }
        Connection con = new Connection();

        String username = null;
        String password = null;

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Open();
            cmd.CommandText = "SELECT username FROM Admin " +
                "WHERE username = '" + txt_username.Text + "' AND password = '" + txt_password.Text + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                username = dr[0].ToString();
            }
            con.Close();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con.Open();
            cmd2.CommandText = "SELECT password FROM Admin " +
                "WHERE username = '" + txt_username.Text + "' AND password = '" + txt_password.Text + "'";
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                password = dr2[0].ToString();
            }
            cmd2.Dispose();
            con.Close();

          
            if (username != txt_username.Text && password != txt_password.Text)
            {
                lbl_message.Visible = true;
                lbl_message.ForeColor = Color.Red;
                this.lbl_message.Location = new System.Drawing.Point(180, 239);
                lbl_message.Text = "Kullanıcı adınızı ya da şifrenizi yanlış\ngirdiniz. Lütfen tekrar deneyiniz.";
            }            
               
             if (username == txt_username.Text && password == txt_password.Text)
             {
                lbl_message.Visible = true;
                lbl_message.ForeColor = Color.Green;
                lbl_message.Text = "Giriş Başarılı.Yönlendiriliyorsunuz.";

                tmr = new System.Windows.Forms.Timer();
                tmr.Tick += delegate
                {
                    FrmMenu form = new FrmMenu();
                    form.Show();
                    this.Hide();
                    tmr.Stop();
                };
                tmr.Interval = (int)TimeSpan.FromSeconds(3).TotalMilliseconds;
                tmr.Start();
            }
        }

        private void btn_changepassword_Click(object sender, EventArgs e)
        {
            FrmPasswordChange form = new FrmPasswordChange();
            form.Show();
            this.Hide();
        }


    }
}
