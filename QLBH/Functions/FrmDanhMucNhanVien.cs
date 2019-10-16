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
    public partial class FrmDanhMucNhanVien : Form
    {
        string connectionString = QLBH.Properties.Settings.Default.DatabaseQuanLyBanHangConnectionString;
        public FrmDanhMucNhanVien()
        {
            InitializeComponent();
        }

        public void LoadDanhMucNhanVien()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = "SELECT * FROM employees";

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
                        adapter.Fill(databaseQuanLyBanHangDataSet.employees);

                        // Hiển thị dữ liệu

                        employeesBindingSource.DataSource = databaseQuanLyBanHangDataSet.employees;
                        employeesDataGridView.Refresh();

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


        /*private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseQuanLyBanHangDataSet);

        }*/

        private void FrmDanhMucNhanVien_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'databaseQuanLyBanHangDataSet.employees' table. You can move, or remove it, as needed.
            // this.employeesTableAdapter.Fill(this.databaseQuanLyBanHangDataSet.employees);
            LoadDanhMucNhanVien();
        }
    }
}
