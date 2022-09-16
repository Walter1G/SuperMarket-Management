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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wally\source\repos\SuperMarket\SuperMarket\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void x_exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fillcombo()
        {
            //bind the combo with the database
            con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from Categorytbl", con);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(sdr);
            categorycombo.ValueMember = "catName";
            categorycombo.DataSource = dt;

            con.Close();
            
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
           
            populate();
        }

        private void categoriesbtn_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            Hide();
            
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            
                try
                {
                    con.Open();
                string query = "insert into ProductTbl values(" + prodidtxt.Text + ",'" + nametxt.Text + "','" + quanititytxt.Text + "', '" + pricetxt.Text + "','" +categorycombo.SelectedValue.ToString()+"')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Added Successfully");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }

        private void populate()
        {
            con.Open();
            string query = "select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prodidtxt.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            nametxt.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
            quanititytxt.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
            pricetxt.Text = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
            categorycombo.SelectedValue = ProdDGV.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
