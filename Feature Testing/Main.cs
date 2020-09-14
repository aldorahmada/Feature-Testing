using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feature_Testing
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 5000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Page_1 homepage = new Page_1();
            homepage.Show();
            homepage.BringToFront();
            timer1.Enabled = false;
            this.Hide();
            

        }
    }
}
