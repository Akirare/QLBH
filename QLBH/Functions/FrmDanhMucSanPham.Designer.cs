using QLBH;

namespace QLBH.Functions
{
    partial class FrmDanhMucSanPham
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
            System.Windows.Forms.Label product_codeLabel;
            System.Windows.Forms.Label product_nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label standard_costLabel;
            System.Windows.Forms.Label list_priceLabel;
            System.Windows.Forms.Label target_levelLabel;
            System.Windows.Forms.Label reorder_levelLabel;
            System.Windows.Forms.Label minimum_reorder_quantityLabel;
            System.Windows.Forms.Label quantity_per_unitLabel;
            System.Windows.Forms.Label discontinuedLabel;
            System.Windows.Forms.Label categoryLabel;
            this.databaseQuanLyBanHangDataSet = new QLBH.DatabaseQuanLyBanHangDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new QLBH.DatabaseQuanLyBanHangDataSetTableAdapters.productsTableAdapter();
            this.tableAdapterManager = new QLBH.DatabaseQuanLyBanHangDataSetTableAdapters.TableAdapterManager();
            this.product_codeTextBox = new System.Windows.Forms.TextBox();
            this.product_nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.standard_costTextBox = new System.Windows.Forms.TextBox();
            this.list_priceTextBox = new System.Windows.Forms.TextBox();
            this.quantity_per_unitTextBox = new System.Windows.Forms.TextBox();
            this.discontinuedTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.reorder_levelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minimum_reorder_quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.target_levelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standardcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetlevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderlevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimumreorderquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityperunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discontinuedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            product_codeLabel = new System.Windows.Forms.Label();
            product_nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            standard_costLabel = new System.Windows.Forms.Label();
            list_priceLabel = new System.Windows.Forms.Label();
            target_levelLabel = new System.Windows.Forms.Label();
            reorder_levelLabel = new System.Windows.Forms.Label();
            minimum_reorder_quantityLabel = new System.Windows.Forms.Label();
            quantity_per_unitLabel = new System.Windows.Forms.Label();
            discontinuedLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseQuanLyBanHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reorder_levelNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimum_reorder_quantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target_levelNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // product_codeLabel
            // 
            product_codeLabel.AutoSize = true;
            product_codeLabel.Location = new System.Drawing.Point(12, 9);
            product_codeLabel.Name = "product_codeLabel";
            product_codeLabel.Size = new System.Drawing.Size(73, 13);
            product_codeLabel.TabIndex = 1;
            product_codeLabel.Text = "product code:";
            // 
            // product_nameLabel
            // 
            product_nameLabel.AutoSize = true;
            product_nameLabel.Location = new System.Drawing.Point(10, 37);
            product_nameLabel.Name = "product_nameLabel";
            product_nameLabel.Size = new System.Drawing.Size(75, 13);
            product_nameLabel.TabIndex = 2;
            product_nameLabel.Text = "product name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(24, 65);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(61, 13);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "description:";
            // 
            // standard_costLabel
            // 
            standard_costLabel.AutoSize = true;
            standard_costLabel.Location = new System.Drawing.Point(11, 91);
            standard_costLabel.Name = "standard_costLabel";
            standard_costLabel.Size = new System.Drawing.Size(74, 13);
            standard_costLabel.TabIndex = 6;
            standard_costLabel.Text = "standard cost:";
            // 
            // list_priceLabel
            // 
            list_priceLabel.AutoSize = true;
            list_priceLabel.Location = new System.Drawing.Point(211, 9);
            list_priceLabel.Name = "list_priceLabel";
            list_priceLabel.Size = new System.Drawing.Size(48, 13);
            list_priceLabel.TabIndex = 8;
            list_priceLabel.Text = "list price:";
            // 
            // target_levelLabel
            // 
            target_levelLabel.AutoSize = true;
            target_levelLabel.Location = new System.Drawing.Point(197, 37);
            target_levelLabel.Name = "target_levelLabel";
            target_levelLabel.Size = new System.Drawing.Size(62, 13);
            target_levelLabel.TabIndex = 10;
            target_levelLabel.Text = "target level:";
            // 
            // reorder_levelLabel
            // 
            reorder_levelLabel.AutoSize = true;
            reorder_levelLabel.Location = new System.Drawing.Point(197, 62);
            reorder_levelLabel.Name = "reorder_levelLabel";
            reorder_levelLabel.Size = new System.Drawing.Size(68, 13);
            reorder_levelLabel.TabIndex = 12;
            reorder_levelLabel.Text = "reorder level:";
            // 
            // minimum_reorder_quantityLabel
            // 
            minimum_reorder_quantityLabel.AutoSize = true;
            minimum_reorder_quantityLabel.Location = new System.Drawing.Point(197, 91);
            minimum_reorder_quantityLabel.Name = "minimum_reorder_quantityLabel";
            minimum_reorder_quantityLabel.Size = new System.Drawing.Size(126, 13);
            minimum_reorder_quantityLabel.TabIndex = 14;
            minimum_reorder_quantityLabel.Text = "minimum reorder quantity:";
            // 
            // quantity_per_unitLabel
            // 
            quantity_per_unitLabel.AutoSize = true;
            quantity_per_unitLabel.Location = new System.Drawing.Point(441, 9);
            quantity_per_unitLabel.Name = "quantity_per_unitLabel";
            quantity_per_unitLabel.Size = new System.Drawing.Size(85, 13);
            quantity_per_unitLabel.TabIndex = 16;
            quantity_per_unitLabel.Text = "quantity per unit:";
            // 
            // discontinuedLabel
            // 
            discontinuedLabel.AutoSize = true;
            discontinuedLabel.Location = new System.Drawing.Point(456, 37);
            discontinuedLabel.Name = "discontinuedLabel";
            discontinuedLabel.Size = new System.Drawing.Size(70, 13);
            discontinuedLabel.TabIndex = 18;
            discontinuedLabel.Text = "discontinued:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(475, 65);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(51, 13);
            categoryLabel.TabIndex = 20;
            categoryLabel.Text = "category:";
            // 
            // databaseQuanLyBanHangDataSet
            // 
            this.databaseQuanLyBanHangDataSet.DataSetName = "DatabaseQuanLyBanHangDataSet";
            this.databaseQuanLyBanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.databaseQuanLyBanHangDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.configsTableAdapter = null;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.order_detailsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLBH.DatabaseQuanLyBanHangDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // product_codeTextBox
            // 
            this.product_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "product_code", true));
            this.product_codeTextBox.Location = new System.Drawing.Point(91, 6);
            this.product_codeTextBox.Name = "product_codeTextBox";
            this.product_codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_codeTextBox.TabIndex = 2;
            // 
            // product_nameTextBox
            // 
            this.product_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "product_name", true));
            this.product_nameTextBox.Location = new System.Drawing.Point(91, 34);
            this.product_nameTextBox.Name = "product_nameTextBox";
            this.product_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_nameTextBox.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(91, 62);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // standard_costTextBox
            // 
            this.standard_costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "standard_cost", true));
            this.standard_costTextBox.Location = new System.Drawing.Point(91, 88);
            this.standard_costTextBox.Name = "standard_costTextBox";
            this.standard_costTextBox.Size = new System.Drawing.Size(100, 20);
            this.standard_costTextBox.TabIndex = 7;
            // 
            // list_priceTextBox
            // 
            this.list_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "list_price", true));
            this.list_priceTextBox.Location = new System.Drawing.Point(271, 9);
            this.list_priceTextBox.Name = "list_priceTextBox";
            this.list_priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.list_priceTextBox.TabIndex = 9;
            // 
            // quantity_per_unitTextBox
            // 
            this.quantity_per_unitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "quantity_per_unit", true));
            this.quantity_per_unitTextBox.Location = new System.Drawing.Point(532, 6);
            this.quantity_per_unitTextBox.Name = "quantity_per_unitTextBox";
            this.quantity_per_unitTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantity_per_unitTextBox.TabIndex = 17;
            // 
            // discontinuedTextBox
            // 
            this.discontinuedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "discontinued", true));
            this.discontinuedTextBox.Location = new System.Drawing.Point(532, 34);
            this.discontinuedTextBox.Name = "discontinuedTextBox";
            this.discontinuedTextBox.Size = new System.Drawing.Size(100, 20);
            this.discontinuedTextBox.TabIndex = 19;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(532, 62);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoryTextBox.TabIndex = 21;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoGenerateColumns = false;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productcodeDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.standardcostDataGridViewTextBoxColumn,
            this.listpriceDataGridViewTextBoxColumn,
            this.targetlevelDataGridViewTextBoxColumn,
            this.reorderlevelDataGridViewTextBoxColumn,
            this.minimumreorderquantityDataGridViewTextBoxColumn,
            this.quantityperunitDataGridViewTextBoxColumn,
            this.discontinuedDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.dgvSanPham.DataSource = this.productsBindingSource;
            this.dgvSanPham.Location = new System.Drawing.Point(15, 124);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(641, 220);
            this.dgvSanPham.TabIndex = 22;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(581, 357);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(500, 357);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 23;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(419, 357);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(338, 357);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(257, 357);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // reorder_levelNumericUpDown
            // 
            this.reorder_levelNumericUpDown.Location = new System.Drawing.Point(271, 60);
            this.reorder_levelNumericUpDown.Name = "reorder_levelNumericUpDown";
            this.reorder_levelNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.reorder_levelNumericUpDown.TabIndex = 24;
            // 
            // minimum_reorder_quantityNumericUpDown
            // 
            this.minimum_reorder_quantityNumericUpDown.Location = new System.Drawing.Point(329, 89);
            this.minimum_reorder_quantityNumericUpDown.Name = "minimum_reorder_quantityNumericUpDown";
            this.minimum_reorder_quantityNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.minimum_reorder_quantityNumericUpDown.TabIndex = 24;
            // 
            // target_levelNumericUpDown
            // 
            this.target_levelNumericUpDown.Location = new System.Drawing.Point(271, 34);
            this.target_levelNumericUpDown.Name = "target_levelNumericUpDown";
            this.target_levelNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.target_levelNumericUpDown.TabIndex = 24;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productcodeDataGridViewTextBoxColumn
            // 
            this.productcodeDataGridViewTextBoxColumn.DataPropertyName = "product_code";
            this.productcodeDataGridViewTextBoxColumn.HeaderText = "product_code";
            this.productcodeDataGridViewTextBoxColumn.Name = "productcodeDataGridViewTextBoxColumn";
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // standardcostDataGridViewTextBoxColumn
            // 
            this.standardcostDataGridViewTextBoxColumn.DataPropertyName = "standard_cost";
            this.standardcostDataGridViewTextBoxColumn.HeaderText = "standard_cost";
            this.standardcostDataGridViewTextBoxColumn.Name = "standardcostDataGridViewTextBoxColumn";
            // 
            // listpriceDataGridViewTextBoxColumn
            // 
            this.listpriceDataGridViewTextBoxColumn.DataPropertyName = "list_price";
            this.listpriceDataGridViewTextBoxColumn.HeaderText = "list_price";
            this.listpriceDataGridViewTextBoxColumn.Name = "listpriceDataGridViewTextBoxColumn";
            // 
            // targetlevelDataGridViewTextBoxColumn
            // 
            this.targetlevelDataGridViewTextBoxColumn.DataPropertyName = "target_level";
            this.targetlevelDataGridViewTextBoxColumn.HeaderText = "target_level";
            this.targetlevelDataGridViewTextBoxColumn.Name = "targetlevelDataGridViewTextBoxColumn";
            // 
            // reorderlevelDataGridViewTextBoxColumn
            // 
            this.reorderlevelDataGridViewTextBoxColumn.DataPropertyName = "reorder_level";
            this.reorderlevelDataGridViewTextBoxColumn.HeaderText = "reorder_level";
            this.reorderlevelDataGridViewTextBoxColumn.Name = "reorderlevelDataGridViewTextBoxColumn";
            // 
            // minimumreorderquantityDataGridViewTextBoxColumn
            // 
            this.minimumreorderquantityDataGridViewTextBoxColumn.DataPropertyName = "minimum_reorder_quantity";
            this.minimumreorderquantityDataGridViewTextBoxColumn.HeaderText = "minimum_reorder_quantity";
            this.minimumreorderquantityDataGridViewTextBoxColumn.Name = "minimumreorderquantityDataGridViewTextBoxColumn";
            // 
            // quantityperunitDataGridViewTextBoxColumn
            // 
            this.quantityperunitDataGridViewTextBoxColumn.DataPropertyName = "quantity_per_unit";
            this.quantityperunitDataGridViewTextBoxColumn.HeaderText = "quantity_per_unit";
            this.quantityperunitDataGridViewTextBoxColumn.Name = "quantityperunitDataGridViewTextBoxColumn";
            // 
            // discontinuedDataGridViewTextBoxColumn
            // 
            this.discontinuedDataGridViewTextBoxColumn.DataPropertyName = "discontinued";
            this.discontinuedDataGridViewTextBoxColumn.HeaderText = "discontinued";
            this.discontinuedDataGridViewTextBoxColumn.Name = "discontinuedDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // FrmDanhMucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 383);
            this.Controls.Add(this.minimum_reorder_quantityNumericUpDown);
            this.Controls.Add(this.target_levelNumericUpDown);
            this.Controls.Add(this.reorder_levelNumericUpDown);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(discontinuedLabel);
            this.Controls.Add(this.discontinuedTextBox);
            this.Controls.Add(quantity_per_unitLabel);
            this.Controls.Add(this.quantity_per_unitTextBox);
            this.Controls.Add(minimum_reorder_quantityLabel);
            this.Controls.Add(reorder_levelLabel);
            this.Controls.Add(target_levelLabel);
            this.Controls.Add(list_priceLabel);
            this.Controls.Add(this.list_priceTextBox);
            this.Controls.Add(standard_costLabel);
            this.Controls.Add(this.standard_costTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(product_nameLabel);
            this.Controls.Add(this.product_nameTextBox);
            this.Controls.Add(product_codeLabel);
            this.Controls.Add(this.product_codeTextBox);
            this.Name = "FrmDanhMucSanPham";
            this.Text = "FrmDanhMucSanPham";
            this.Load += new System.EventHandler(this.FrmDanhMucSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseQuanLyBanHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reorder_levelNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimum_reorder_quantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target_levelNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseQuanLyBanHangDataSet databaseQuanLyBanHangDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private QLBH.DatabaseQuanLyBanHangDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private QLBH.DatabaseQuanLyBanHangDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox product_codeTextBox;
        private System.Windows.Forms.TextBox product_nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox standard_costTextBox;
        private System.Windows.Forms.TextBox list_priceTextBox;
        private System.Windows.Forms.TextBox quantity_per_unitTextBox;
        private System.Windows.Forms.TextBox discontinuedTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown reorder_levelNumericUpDown;
        private System.Windows.Forms.NumericUpDown minimum_reorder_quantityNumericUpDown;
        private System.Windows.Forms.NumericUpDown target_levelNumericUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn standardcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetlevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderlevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimumreorderquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityperunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discontinuedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    }
}