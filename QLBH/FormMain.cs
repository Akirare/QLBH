using QLBH.Functions;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void cấuHìnhToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDanhMucKhachHang frmKH = new FrmDanhMucKhachHang();
            
            frmKH.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDanhMucNhanVien frmNV = new FrmDanhMucNhanVien();
            frmNV.Show();
        }

        private void đặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatHang frDH = new FrmDatHang();
           
            frDH.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDanhMucSanPham frSP = new FrmDanhMucSanPham();
            frSP.MdiParent = this;
            frSP.Show();
        }

        private void cấuHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCauHinh frmCauHinh = new FrmCauHinh();
            frmCauHinh.MdiParent = this;
            frmCauHinh.Show();
        }

       
    }
}
