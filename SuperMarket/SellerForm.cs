using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }

        private void categoriesbtn_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            Hide();
            category.Show();
        }

        private void x_exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productsbtn_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            Hide();
        }
    }
}
