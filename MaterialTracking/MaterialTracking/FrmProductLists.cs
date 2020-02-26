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
    public partial class FrmProductLists : Form
    {
        Connection con = new Connection();
        public FrmProductLists()
        {
            InitializeComponent();
        }
        private void FrmProductLists_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Open();
            cmd.CommandText = "SELECT product_name AS 'Ürün Adi' , product_amount AS 'Ürün Miktari ', " +
                "productRegister.product_date AS 'Ürün Kayit Tarihi' " +
                "FROM productRegister " +
                "INNER JOIN productAdd ON productAdd.product_barcod = productRegister.product_barcod " +
                "ORDER BY productRegister.product_date DESC";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.Dispose();
            con.Close();
        }
    }
}
