using System;
using System.ComponentModel.Design;
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
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class subpage1 : UserControl
    {
        public subpage1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
        }
    }
}
