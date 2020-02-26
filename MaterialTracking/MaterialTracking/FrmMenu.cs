using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodOlusturma
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btn_productRegister_Click(object sender, EventArgs e)
        {
            FrmProductRegister form = new FrmProductRegister();
            form.Show();
            this.Hide();
        }

        private void btn_productList_Click(object sender, EventArgs e)
        {
            FrmProductLists form = new FrmProductLists();
            form.Show();
            this.Hide();
        }

        private void btn_productAdd_Click(object sender, EventArgs e)
        {
            FrmProductAddAmount form = new FrmProductAddAmount();
            form.Show();
            this.Hide();
        }

        private void btn_productSubtract_Click(object sender, EventArgs e)
        {
            FrmProductSubtract form = new FrmProductSubtract();
            form.Show();
            this.Hide();
        }

        private void btn_AddBarcode_Click(object sender, EventArgs e)
        {
            FrmAddBarcode form = new FrmAddBarcode();
            form.Show();
            this.Hide();
        }
    }
}
