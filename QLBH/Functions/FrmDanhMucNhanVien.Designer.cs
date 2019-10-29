using QLBH;

namespace QLBH.Functions
{
    partial class FrmDanhMucNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label avatarLabel;
            System.Windows.Forms.Label job_titleLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label manager_idLabel;
            System.Windows.Forms.Label postal_codeLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label countryLabel;
            this.databaseQuanLyBanHangDataSet = new QLBH.DatabaseQuanLyBanHangDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new QLBH.DatabaseQuanLyBanHangDataSetTableAdapters.employeesTableAdapter();
            this.tableAdapterManager = new QLBH.DatabaseQuanLyBanHangDataSetTableAdapters.TableAdapterManager();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.avatarTextBox = new System.Windows.Forms.TextBox();
            this.job_titleTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.postal_codeTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.manager_idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            last_nameLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            avatarLabel = new System.Windows.Forms.Label();
            job_titleLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            manager_idLabel = new System.Windows.Forms.Label();
            postal_codeLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseQuanLyBanHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_idNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(12, 21);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(55, 13);
            last_nameLabel.TabIndex = 1;
            last_nameLabel.Text = "last name:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(12, 49);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(55, 13);
            first_nameLabel.TabIndex = 2;
            first_nameLabel.Text = "first name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(33, 77);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "email:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(12, 104);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(55, 13);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "password:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(33, 131);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(33, 13);
            stateLabel.TabIndex = 8;
            stateLabel.Text = "state:";
            // 
            // avatarLabel
            // 
            avatarLabel.AutoSize = true;
            avatarLabel.Location = new System.Drawing.Point(207, 21);
            avatarLabel.Name = "avatarLabel";
            avatarLabel.Size = new System.Drawing.Size(40, 13);
            avatarLabel.TabIndex = 10;
            avatarLabel.Text = "avatar:";
            // 
            // job_titleLabel
            // 
            job_titleLabel.AutoSize = true;
            job_titleLabel.Location = new System.Drawing.Point(204, 49);
            job_titleLabel.Name = "job_titleLabel";
            job_titleLabel.Size = new System.Drawing.Size(43, 13);
            job_titleLabel.TabIndex = 12;
            job_titleLabel.Text = "job title:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(184, 77);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(63, 13);
            departmentLabel.TabIndex = 14;
            departmentLabel.Text = "department:";
            // 
            // manager_idLabel
            // 
            manager_idLabel.AutoSize = true;
            manager_idLabel.Location = new System.Drawing.Point(184, 104);
            manager_idLabel.Name = "manager_idLabel";
            manager_idLabel.Size = new System.Drawing.Size(62, 13);
            manager_idLabel.TabIndex = 16;
            manager_idLabel.Text = "manager id:";
            // 
            // postal_codeLabel
            // 
            postal_codeLabel.AutoSize = true;
            postal_codeLabel.Location = new System.Drawing.Point(181, 131);
            postal_codeLabel.Name = "postal_codeLabel";
            postal_codeLabel.Size = new System.Drawing.Size(65, 13);
            postal_codeLabel.TabIndex = 18;
            postal_codeLabel.Text = "postal code:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(386, 21);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(40, 13);
            phoneLabel.TabIndex = 20;
            phoneLabel.Text = "phone:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(373, 49);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(53, 13);
            address1Label.TabIndex = 22;
            address1Label.Text = "address1:";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new System.Drawing.Point(373, 77);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(53, 13);
            address2Label.TabIndex = 24;
            address2Label.Text = "address2:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(400, 104);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(26, 13);
            cityLabel.TabIndex = 26;
            cityLabel.Text = "city:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(381, 131);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(45, 13);
            countryLabel.TabIndex = 28;
            countryLabel.Text = "country:";
            // 
            // databaseQuanLyBanHangDataSet
            // 
            this.databaseQuanLyBanHangDataSet.DataSetName = "DatabaseQuanLyBanHangDataSet";
            this.databaseQuanLyBanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.databaseQuanLyBanHangDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.configsTableAdapter = null;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.order_detailsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLBH.DatabaseQuanLyBanHangDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "last_name", true));
            this.last_nameTextBox.Location = new System.Drawing.Point(73, 18);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.last_nameTextBox.TabIndex = 2;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "first_name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(73, 46);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.first_nameTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(73, 74);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(73, 101);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 7;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "state", true));
            this.stateTextBox.Location = new System.Drawing.Point(72, 128);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateTextBox.TabIndex = 9;
            // 
            // avatarTextBox
            // 
            this.avatarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "avatar", true));
            this.avatarTextBox.Location = new System.Drawing.Point(253, 18);
            this.avatarTextBox.Name = "avatarTextBox";
            this.avatarTextBox.Size = new System.Drawing.Size(100, 20);
            this.avatarTextBox.TabIndex = 11;
            // 
            // job_titleTextBox
            // 
            this.job_titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "job_title", true));
            this.job_titleTextBox.Location = new System.Drawing.Point(253, 46);
            this.job_titleTextBox.Name = "job_titleTextBox";
            this.job_titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.job_titleTextBox.TabIndex = 13;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(253, 74);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(100, 20);
            this.departmentTextBox.TabIndex = 15;
            // 
            // postal_codeTextBox
            // 
            this.postal_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "postal_code", true));
            this.postal_codeTextBox.Location = new System.Drawing.Point(252, 128);
            this.postal_codeTextBox.Name = "postal_codeTextBox";
            this.postal_codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.postal_codeTextBox.TabIndex = 19;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(432, 18);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 21;
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "address1", true));
            this.address1TextBox.Location = new System.Drawing.Point(432, 46);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(100, 20);
            this.address1TextBox.TabIndex = 23;
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "address2", true));
            this.address2TextBox.Location = new System.Drawing.Point(432, 74);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(100, 20);
            this.address2TextBox.TabIndex = 25;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(432, 101);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 27;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "country", true));
            this.countryTextBox.Location = new System.Drawing.Point(432, 128);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.countryTextBox.TabIndex = 29;
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AutoGenerateColumns = false;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.employeesDataGridView.DataSource = this.employeesBindingSource;
            this.employeesDataGridView.Location = new System.Drawing.Point(12, 154);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.Size = new System.Drawing.Size(627, 220);
            this.employeesDataGridView.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "last_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "last_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "first_name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn4.HeaderText = "email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn5.HeaderText = "password";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "avatar";
            this.dataGridViewTextBoxColumn6.HeaderText = "avatar";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "job_title";
            this.dataGridViewTextBoxColumn7.HeaderText = "job_title";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "department";
            this.dataGridViewTextBoxColumn8.HeaderText = "department";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "manager_id";
            this.dataGridViewTextBoxColumn9.HeaderText = "manager_id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn10.HeaderText = "phone";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "address1";
            this.dataGridViewTextBoxColumn11.HeaderText = "address1";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "address2";
            this.dataGridViewTextBoxColumn12.HeaderText = "address2";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn13.HeaderText = "city";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "state";
            this.dataGridViewTextBoxColumn14.HeaderText = "state";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "postal_code";
            this.dataGridViewTextBoxColumn15.HeaderText = "postal_code";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "country";
            this.dataGridViewTextBoxColumn16.HeaderText = "country";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(564, 390);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(483, 390);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 31;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(403, 390);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(322, 390);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(241, 390);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
      
            // 
            // manager_idNumericUpDown
            // 
            this.manager_idNumericUpDown.Location = new System.Drawing.Point(253, 101);
            this.manager_idNumericUpDown.Name = "manager_idNumericUpDown";
            this.manager_idNumericUpDown.Size = new System.Drawing.Size(101, 20);
            this.manager_idNumericUpDown.TabIndex = 32;
            // 
            // FrmDanhMucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 418);
            this.Controls.Add(this.manager_idNumericUpDown);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.employeesDataGridView);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(address2Label);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(postal_codeLabel);
            this.Controls.Add(this.postal_codeTextBox);
            this.Controls.Add(manager_idLabel);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(job_titleLabel);
            this.Controls.Add(this.job_titleTextBox);
            this.Controls.Add(avatarLabel);
            this.Controls.Add(this.avatarTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(this.first_nameTextBox);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(this.last_nameTextBox);
            this.Name = "FrmDanhMucNhanVien";
            this.Text = "FrmDanhMucNhanVien";
            this.Load += new System.EventHandler(this.FrmDanhMucNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseQuanLyBanHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_idNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseQuanLyBanHangDataSet databaseQuanLyBanHangDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private QLBH.DatabaseQuanLyBanHangDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private QLBH.DatabaseQuanLyBanHangDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox avatarTextBox;
        private System.Windows.Forms.TextBox job_titleTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox postal_codeTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown manager_idNumericUpDown;
    }
}