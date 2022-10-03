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

namespace SuperMarket
{
    public partial class loginfrm : Form
    {
        public loginfrm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wally\source\repos\SuperMarket\SuperMarket\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
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
                    else
                    {
                        //MessageBox.Show("You are in the Seller Section");
                        con.Open();
                        string query = "select count(8) from sellerTbl where SellerName='" + userNametxt.Text + "' and SellerPass='" + passwordtxt.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(query, con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            SellingForm sell = new SellingForm();   
                            sell.Show();
                            Hide();
                            con.Close();

                        }
                        else
                        {
                            MessageBox.Show("Username and Password do not match");
                        }
                        con.Close();

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
