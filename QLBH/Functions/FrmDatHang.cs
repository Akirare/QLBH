using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.Functions
{
    public partial class FrmDatHang : Form
    {
        string connectionString = QLBH.Properties.Settings.Default.DatabaseQuanLyBanHangConnectionString;
        public FrmDatHang()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseQuanLyBanHangDataSet);

        }

        private void FrmDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseQuanLyBanHangDataSet.order_details' table. You can move, or remove it, as needed.
            // this.order_detailsTableAdapter.Fill(this.databaseQuanLyBanHangDataSet.order_details);
            // TODO: This line of code loads data into the 'databaseQuanLyBanHangDataSet.orders' table. You can move, or remove it, as needed.
             //this.ordersTableAdapter.Fill(this.databaseQuanLyBanHangDataSet.orders);
            LoadDanhSachDonHang();
        }

     
      
            public void LoadDanhSachDonHang()
            {
               
                string tuNgay = dtpTuNgay.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string denNgay = dtpDenNgay.Value.ToString("yyyy-MM-dd HH:mm:ss");

                // Tạo câu lệnh để thực thi đến database
                string queryString = String.Format("SELECT * FROM orders WHERE order_date BETWEEN '{0}' AND '{1}'", tuNgay, denNgay);

                // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        try
                        {
                            // Mở kết nối đến Database Server
                            connection.Open();

                            // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                            SqlDataAdapter adapter = new SqlDataAdapter();
                            adapter.SelectCommand = command;

                            // Đổ dữ liệu vào dataset
                            databaseQuanLyBanHangDataSet.orders.Clear();
                            adapter.Fill(databaseQuanLyBanHangDataSet.orders);

                            // Hiển thị dữ liệu
                            ordersBindingSource.DataSource = null;
                            ordersBindingSource.DataSource = databaseQuanLyBanHangDataSet.orders;
                            dgvDonHang.Refresh();

                            // Ngắt kết nối đến Database Server
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            // Hiển thị thông báo nếu có lỗi
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }

            

        private void btnDS_Click(object sender, EventArgs e)
        {
            LoadDanhSachDonHang();
        }
    }
}

