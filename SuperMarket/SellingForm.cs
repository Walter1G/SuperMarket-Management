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
       

        private void populateBills()
        {
            con.Open();
            string query = "select BillId,SellerName,BillDate,TotalAmt from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var bills = new DataSet();
            sda.Fill(bills);
            billDGV.DataSource = bills.Tables[0];
            con.Close();
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            populateBills();
            fillcombo();
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
                billamountlbl1.Text = "KES/- ";
                billamountlbl.Text =""+ grandTotal;
                n++;
            }

            

        }

        private void addBillbtn_Click(object sender, EventArgs e)
        {
            if (billidtxt.Text == "")
            {
                MessageBox.Show("Missing Bill ID");
            }
            else
            {
                try
                {
                    
                    con.Open();
                    string query = "insert into BillTbl values('" +billidtxt.Text+ "','" +sellerlbl.Text+ "','" +datelbl.Text+ "','" + grandTotal+ "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfully");
                    con.Close();

                    populateBills();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

      
        private void printbtn_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void billDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Family SuperMarket", new Font("Century Gothic", 25, FontStyle.Bold),Brushes.Red, new Point(230));
            e.Graphics.DrawString("Walter1G", new Font("Century Gothic", 20, FontStyle.Italic),Brushes.Red, new Point(300,230));
            e.Graphics.DrawString("Bill ID: "+billDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold),Brushes.Blue, new Point(70,70));
            e.Graphics.DrawString("Seller Name: "+billDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold),Brushes.Blue, new Point(70,100));
            e.Graphics.DrawString("Date: "+billDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold),Brushes.Blue, new Point(70,130));
            e.Graphics.DrawString("Total Amount: "+billDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold),Brushes.Blue, new Point(70,160));

        }

        private void refressProductsbtn_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void categorycombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Open();
            string query = "select ProdName,ProdQty from ProductTbl where ProdCat='"+categorycombo.SelectedValue.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodDVG1.DataSource = ds.Tables[0];
            con.Close();

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

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            loginfrm login = new loginfrm();
            login.Show();
            Hide();

        }
    }
}
