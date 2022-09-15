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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wally\source\repos\SuperMarket\SuperMarket\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into Categorytbl values("+catidtxt.Text+",'"+catnametxt.Text+"','"+catdescriptiontxt.Text+"')";
                SqlCommand cmd=new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                con.Close();
                populate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populate()
        {
            con.Open();
            string query = "select * from Categorytbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            catidtxt.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            catnametxt.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            catdescriptiontxt.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(catidtxt.Text == "")
                {
                    MessageBox.Show("Select the Category to Delete");
                }
                else
                {
                    con.Open();
                    string query = "delete from Categorytbl where CatId=" + catidtxt.Text + "";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted successfully");
                    con.Close();

                    populate();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (catidtxt.Text == "" || catnametxt.Text=="" || catdescriptiontxt.Text=="")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {

                    con.Open();
                    string query = "update Categorytbl set CatName='" + catnametxt.Text + "', CatDesc='" + catdescriptiontxt.Text + "' where Catid=" + catidtxt.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully updated");

                    con.Close();
                    populate();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void x_exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
