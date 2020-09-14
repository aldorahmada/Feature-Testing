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
    public partial class subpage3 : UserControl
    {
        public subpage3()
        {
            InitializeComponent();

        }

        private void subpage3_Load(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            documentViewer1.LoadDocument(openFileDialog1.FileName);
        }
    }
}
