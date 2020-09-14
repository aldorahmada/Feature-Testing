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
            // ||M a r s h a l  T r i a l||
            //this is marshal trial, but i don't know yet how to try it
            //this should be an easy trial by using the marshall to write and read the memory
            label1.Text = "HELLO";
            int memori = 97;
            //short Pmemori;
            string data = Convert.ToString(Marshal.SizeOf(memori));
            label1.Text = data;
            textBox1.Text = Convert.ToString(Marshal.AllocCoTaskMem(memori));
            //Marshal.PtrToStructure<Pmemori>;
           
        }   

        private void Page_2_Load(object sender, EventArgs e)
        {

        }
    }
}
