using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Feature_Testing
{
    public partial class Page_2 : Form
    {
        public Page_2()
        {
            InitializeComponent();

            //this is marshal trial, but i don't know yet how to try it
            //this should be an easy trial by using the marshall to write and read the memory
            int memori = Convert.ToInt32(textBox1.Text);
            int data = Marshal.SizeOf(memori);
            label1.Text = Convert.ToString(data);
        }   

        private void Page_2_Load(object sender, EventArgs e)
        {

        }
    }
}
