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
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wally\source\repos\SuperMarket\SuperMarket\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            string query = "select ProdName,ProdQty from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodDVG1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void prodDVG1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nametxt.Text = prodDVG1.SelectedRows[0].Cells[0].Value.ToString();
            pricetxt.Text = prodDVG1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void x_exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manageProductspnl_Paint(object sender, PaintEventArgs e)
        {
            datelbl.Text = $"{DateTime.Today.Day.ToString()}/{DateTime.Today.Month}/{DateTime.Today.Year.ToString()}";

                }
        int n = 0;
        int grandTotal = 0;
        private void addProductbtn_Click(object sender, EventArgs e)
        {
            if (nametxt.Text == "" || quantitytxt.Text == "")
            {
                MessageBox.Show("Missing info");
            }
            else
            {
                int total = Convert.ToInt32(pricetxt.Text) * Convert.ToInt32(quantitytxt.Text);


                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(orderDVG);
                newrow.Cells[0].Value = n + 1;
                newrow.Cells[1].Value = nametxt.Text;
                newrow.Cells[2].Value = pricetxt.Text;
                newrow.Cells[3].Value = quantitytxt.Text;
                newrow.Cells[4].Value = Convert.ToInt32(pricetxt.Text) * Convert.ToInt32(quantitytxt.Text);

                orderDVG.Rows.Add(newrow);
                grandTotal = grandTotal + total;

                billamountlbl.Text = $"KES/- {grandTotal}";
                n++;
            }

            

        }
    }
}
