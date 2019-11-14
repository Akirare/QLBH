using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class FormNgayThang : Form
    {
        public FormNgayThang()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
        MessageBox.Show(txthoten.Text + "\n" + cbbD.Text + "/" + cbbM.Text + "/" + cbbY.Text);
                
        }

        private void FormNgayThang_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cLOSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
