namespace SmartphoneShop
{
    partial class ManageProduct
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
            gbProductInformation = new GroupBox();
            cbCategory = new ComboBox();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnUpload = new Button();
            txtProductImg = new TextBox();
            txtProductQuantity = new TextBox();
            txtProductPrice = new TextBox();
            txtProductName = new TextBox();
            txtProductCode = new TextBox();
            lblCategory = new Label();
            lblProductImg = new Label();
            lblProductQuantity = new Label();
            lblProductPrice = new Label();
            lblProductName = new Label();
            lblProductCode = new Label();
            gbProductData = new GroupBox();
            dtgProduct = new DataGridView();
            txtSearch = new TextBox();
            btnBack = new Button();
            gbProductInformation.SuspendLayout();
            gbProductData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProduct).BeginInit();
            SuspendLayout();
            // 
            // gbProductInformation
            // 
            gbProductInformation.Controls.Add(cbCategory);
            gbProductInformation.Controls.Add(btnClear);
            gbProductInformation.Controls.Add(btnUpdate);
            gbProductInformation.Controls.Add(btnDelete);
            gbProductInformation.Controls.Add(btnAdd);
            gbProductInformation.Controls.Add(btnUpload);
            gbProductInformation.Controls.Add(txtProductImg);
            gbProductInformation.Controls.Add(txtProductQuantity);
            gbProductInformation.Controls.Add(txtProductPrice);
            gbProductInformation.Controls.Add(txtProductName);
            gbProductInformation.Controls.Add(txtProductCode);
            gbProductInformation.Controls.Add(lblCategory);
            gbProductInformation.Controls.Add(lblProductImg);
            gbProductInformation.Controls.Add(lblProductQuantity);
            gbProductInformation.Controls.Add(lblProductPrice);
            gbProductInformation.Controls.Add(lblProductName);
            gbProductInformation.Controls.Add(lblProductCode);
            gbProductInformation.Location = new Point(12, 12);
            gbProductInformation.Name = "gbProductInformation";
            gbProductInformation.Size = new Size(383, 362);
            gbProductInformation.TabIndex = 0;
            gbProductInformation.TabStop = false;
            gbProductInformation.Text = "Product Information";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(151, 238);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(216, 28);
            cbCategory.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(245, 315);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 29);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(245, 280);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(41, 315);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(41, 280);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(289, 198);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(78, 29);
            btnUpload.TabIndex = 2;
            btnUpload.Text = "...";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // txtProductImg
            // 
            txtProductImg.Enabled = false;
            txtProductImg.Location = new Point(151, 199);
            txtProductImg.Name = "txtProductImg";
            txtProductImg.ReadOnly = true;
            txtProductImg.Size = new Size(127, 27);
            txtProductImg.TabIndex = 1;
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.Location = new Point(151, 160);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(216, 27);
            txtProductQuantity.TabIndex = 1;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(151, 123);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(216, 27);
            txtProductPrice.TabIndex = 1;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(151, 85);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(216, 27);
            txtProductName.TabIndex = 1;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(151, 47);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(216, 27);
            txtProductCode.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(23, 238);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 20);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category";
            // 
            // lblProductImg
            // 
            lblProductImg.AutoSize = true;
            lblProductImg.Location = new Point(23, 199);
            lblProductImg.Name = "lblProductImg";
            lblProductImg.Size = new Size(106, 20);
            lblProductImg.TabIndex = 0;
            lblProductImg.Text = "Product Image";
            // 
            // lblProductQuantity
            // 
            lblProductQuantity.AutoSize = true;
            lblProductQuantity.Location = new Point(23, 160);
            lblProductQuantity.Name = "lblProductQuantity";
            lblProductQuantity.Size = new Size(120, 20);
            lblProductQuantity.TabIndex = 0;
            lblProductQuantity.Text = "Product Quantity";
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Location = new Point(20, 126);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(96, 20);
            lblProductPrice.TabIndex = 0;
            lblProductPrice.Text = "Product Price";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(20, 88);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(104, 20);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Product Name";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new Point(20, 50);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(99, 20);
            lblProductCode.TabIndex = 0;
            lblProductCode.Text = "Product Code";
            // 
            // gbProductData
            // 
            gbProductData.Controls.Add(dtgProduct);
            gbProductData.Controls.Add(txtSearch);
            gbProductData.Location = new Point(401, 12);
            gbProductData.Name = "gbProductData";
            gbProductData.Size = new Size(387, 362);
            gbProductData.TabIndex = 0;
            gbProductData.TabStop = false;
            gbProductData.Text = "Product Data";
            // 
            // dtgProduct
            // 
            dtgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProduct.Location = new Point(6, 61);
            dtgProduct.Name = "dtgProduct";
            dtgProduct.RowHeadersWidth = 51;
            dtgProduct.Size = new Size(375, 295);
            dtgProduct.TabIndex = 1;
            dtgProduct.CellClick += dtgProduct_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(113, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(268, 27);
            txtSearch.TabIndex = 0;
            txtSearch.KeyUp += txtSearch_KeyUp;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(14, 380);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(117, 58);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ManageProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(gbProductData);
            Controls.Add(gbProductInformation);
            Name = "ManageProduct";
            Text = "ManageProduct";
            Load += ManageProduct_Load;
            gbProductInformation.ResumeLayout(false);
            gbProductInformation.PerformLayout();
            gbProductData.ResumeLayout(false);
            gbProductData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbProductInformation;
        private GroupBox gbProductData;
        private Label lblCategory;
        private Label lblProductImg;
        private Label lblProductQuantity;
        private Label lblProductPrice;
        private Label lblProductName;
        private Label lblProductCode;
        private Button btnUpload;
        private TextBox txtProductImg;
        private TextBox txtProductQuantity;
        private TextBox txtProductPrice;
        private TextBox txtProductName;
        private TextBox txtProductCode;
        private Button btnBack;
        private ComboBox cbCategory;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dtgProduct;
        private TextBox txtSearch;
    }
}