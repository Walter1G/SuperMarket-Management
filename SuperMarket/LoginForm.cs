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
    public partial class loginfrm : Form
    {
        public loginfrm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearlbl_Click(object sender, EventArgs e)
        {
            userNametxt.Text = "";
            passwordtxt.Text = "";
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (userNametxt.Text =="" || passwordtxt.Text== "")
            {
                MessageBox.Show("Enter UserName and Password");
            }
            else
            {
                if (RoleCb.SelectedIndex > -1)
                {
                    if (RoleCb.SelectedItem.ToString() == "ADMIN")
                    {
                        if (userNametxt.Text == "Admin" && passwordtxt.Text == "Admin")
                        {
                            ProductForm prod = new ProductForm();
                            prod.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are the Admin, Enter the correct credentials");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select Role");
                }
            }
        }
    }
}
