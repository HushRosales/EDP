using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP
{
    public partial class page3 : Form
    {
        page2 f1;
        public page3(page2 frm1)
        {
            InitializeComponent();
            this.f1 = frm1;
            {

                dgcolom.ColumnCount = 8;
                dgcolom.Columns[0].Name = "StudentNumber";
                dgcolom.Columns[1].Name = "FULLNAME";
                dgcolom.Columns[2].Name = "DEPARTMENT";
                dgcolom.Columns[3].Name = "COURSE";
                dgcolom.Columns[4].Name = "YEAR/SECTION";
                dgcolom.Columns[5].Name = "KIND OF EVENT";
                dgcolom.Columns[6].Name = "PLACE";
                dgcolom.Columns[7].Name = "DATE/TIME";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void page3_Load(object sender, EventArgs e)
        {
            portalnum.Text = f1.portalnum1.Text;
        }

        private void send_Click(object sender, EventArgs e)
        {
            MemoryStream memoryStream = new MemoryStream();

            dgcolom.Rows.Add(portalnum.Text,
                fullname11.Text,
                DTP1.Value,
                DEPAR.SelectedItem,
                kurso.SelectedItem,
                year.SelectedItem,
                KOF22.Text,
                place11.SelectedItem);
        }
    }
}
