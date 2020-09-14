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
    public partial class Page_1 : Form
    {
        subpage1 satu = new subpage1();
        subpage2 dua = new subpage2();
        subpage3 tiga = new subpage3();
        subpage4 empat = new subpage4();
        Homepage home = new Homepage();

        public Page_1()
        {
            InitializeComponent();


        }

        private void Page_1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(satu);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(dua);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("TabTip.exe");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(tiga);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(empat);
        }
    }
}
