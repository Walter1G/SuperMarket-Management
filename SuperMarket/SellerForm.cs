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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wally\source\repos\SuperMarket\SuperMarket\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
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

        private void sellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idtxt.Text = sellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            nametxt.Text = sellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            agetxt.Text = sellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            phonetxt.Text = sellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            passwordtxt.Text = sellerDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void populate()
        {
            con.Open();
            string query = "select * from SellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            sellerDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into SellerTbl values(" + idtxt.Text + ",'" + nametxt.Text + "','" + agetxt.Text + "', '" + phonetxt.Text + "','" + passwordtxt.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully");
                con.Close();               
                populate();
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (idtxt.Text == "" || nametxt.Text == "" || agetxt.Text == "" ||phonetxt.Text=="" || passwordtxt.Text=="")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {

                    con.Open();
                    string query = "update SellerTbl set SellerName='" + nametxt.Text + "', SellerAge='" + agetxt.Text + "', SellerPhone='"+phonetxt.Text+"', SellerPass='"+passwordtxt+"' where SellerId='" + idtxt.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Successfully updated");

                    con.Close();                    
                    populate();
                    clearFields();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearFields()
        {
            idtxt.Text = "";
            nametxt.Text = "";
            agetxt.Text = "";
            phonetxt.Text = "";
            passwordtxt.Text = "";

        }
        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (idtxt.Text == "")
                {
                    MessageBox.Show("Select the Seller to Delete");
                }
                else
                {
                    con.Open();
                    string query = "delete from SellerTbl where SellerId=" + idtxt.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted successfully");
                    populate();
                    con.Close();

                    
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            loginfrm login = new loginfrm();
            login.Show();
            Hide();

        }
    }
}
