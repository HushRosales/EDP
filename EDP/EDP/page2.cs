using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP
{
    public partial class page2 : Form
    {
        public page2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void enter1_Click(object sender, EventArgs e)
        {
            page3 f2 = new page3(this);
            f2.ShowDialog();
        }

        private void portalnum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }
    }
}
