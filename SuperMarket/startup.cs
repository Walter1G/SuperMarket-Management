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
    public partial class startup : Form
    {
        public startup()
        {
            InitializeComponent();
        }

        private void startup_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value++;

            }
            else
            {
                timer1.Stop();
                progressBar1.Value = 0;
               
                loginfrm loginfrm = new loginfrm();
                Hide();
                loginfrm.Show();
            }
        }
    }
}
