using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.Functions
{
    public partial class FrmDanhMucQuanLyBanHang : Form
    {
        public FrmDanhMucQuanLyBanHang()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseQuanLyBanHangDataSet);

        }

        private void FrmDanhMucQuanLyBanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseQuanLyBanHangDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.databaseQuanLyBanHangDataSet.customers);

        }
    }
}
