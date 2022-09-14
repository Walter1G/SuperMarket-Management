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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        private void Splash_Load(object sender, EventArgs e)
        {

            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Myprogress.Value < 100)
            {
                MessageBox.Show("Start");
                Myprogress.Value++;
                label1.Text = Myprogress.Value.ToString() + "%";

            }
            else
            {
                timer1.Stop();
            }
          
        }

     

        
    }
}
