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
    public partial class page1 : Form
    {
        public page1()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            enter.Hide();
            progressBar1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(5);
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                page2 fm = new page2();
                fm.Show();
            }
        }

        private void page1_Load(object sender, EventArgs e)
        {
            progressBar1.Hide();
        }
    }
}
