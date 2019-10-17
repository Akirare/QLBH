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
    public partial class FrmDanhMucKhachHang : Form
    {
        public FrmDanhMucKhachHang()
        {
            InitializeComponent();
        }
        string connectionString = QLBH.Properties.Settings.Default.DatabaseQuanLyBanHangConnectionString;

        public void LoadDanhMucKhachHang()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = "SELECT * FROM customers";

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
                        adapter.Fill(databaseQuanLyBanHangDataSet.customers);

                        // Hiển thị dữ liệu

                        customersBindingSource.DataSource = databaseQuanLyBanHangDataSet.customers;
                        customersDataGridView.Refresh();

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

        /* private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
         {
             this.Validate();
             this.customersBindingSource.EndEdit();
             this.tableAdapterManager.UpdateAll(this.databaseQuanLyBanHangDataSet);

         }*/

        private void FrmDanhMucQuanLyBanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseQuanLyBanHangDataSet.customers' table. You can move, or remove it, as needed.
            //this.customersTableAdapter.Fill(this.databaseQuanLyBanHangDataSet.customers);
            LoadDanhMucKhachHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (String.IsNullOrEmpty(last_nameTextBox.Text) || String.IsNullOrEmpty(first_nameTextBox.Text) 
                  || String.IsNullOrEmpty(emailTextBox.Text) || String.IsNullOrEmpty(companyTextBox.Text) || String.IsNullOrEmpty(phoneTextBox.Text)
                  || String.IsNullOrEmpty(address1TextBox.Text) || String.IsNullOrEmpty(postal_codeTextBox.Text) || String.IsNullOrEmpty(address2TextBox.Text)
                  || String.IsNullOrEmpty(cityTextBox.Text) || String.IsNullOrEmpty(stateTextBox.Text) || String.IsNullOrEmpty(countryTextBox.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu nhập");
                return;
            }

            // Tạo câu lệnh để thực thi đến database
            string queryString = @"INSERT INTO customers([last_name], [first_name], [email], [company], [phone], [address1], [postal_code], [address2], [city], [state], [country]) VALUES(@last_name, @first_name, @email, @company, @phone, @address1, @postal_code, @address2, @city, @state, @country)";

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

                        // Truyền dữ liệu vào đúng tham số
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@last_name", last_nameTextBox.Text);
                        command.Parameters.AddWithValue("@first_name", first_nameTextBox.Text);
                        command.Parameters.AddWithValue("@email", emailTextBox.Text);
                        command.Parameters.AddWithValue("@company", companyTextBox.Text);
                        command.Parameters.AddWithValue("@phone", phoneTextBox.Text);
                        command.Parameters.AddWithValue("@address1", address1TextBox.Text);
                        command.Parameters.AddWithValue("@postal_code", postal_codeTextBox.Text);
                        command.Parameters.AddWithValue("@address2", address2TextBox.Text);
                        command.Parameters.AddWithValue("@city", cityTextBox.Text);
                        command.Parameters.AddWithValue("@state", stateTextBox.Text);
                        command.Parameters.AddWithValue("@country", countryTextBox.Text);

                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();

                        // Ngắt kết nối đến Database Server
                        connection.Close();

                        // Load lại danh sách cấu hình
                       // LoadDanhMucCauHinh();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
