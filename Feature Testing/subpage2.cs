using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feature_Testing
{
    public partial class subpage2 : UserControl
    {
        public subpage2()
        {
            InitializeComponent();
        }

        private void subpage2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //textBox1.Text += "Preparation_";
            //textBox2.Text += "M1_";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //textBox1.Text += "Machining_";
            //textBox2.Text += "M2_";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //textBox1.Text += "Finishing_";
            //textBox2.Text += "M3_";
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            textBox1.Text += "Preparation_";
            textBox2.Text += "M1_";
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            textBox1.Text += "Machining_";
            textBox2.Text += "M2_";
        }
    }
}
