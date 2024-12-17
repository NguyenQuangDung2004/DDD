namespace SmartphoneShop
{
    partial class ManageCustomer
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
            gbCustomerManager = new GroupBox();
            dtgCustomer = new DataGridView();
            txtSearch = new TextBox();
            lblSearch = new Label();
            gbCustomerInformation = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            txtCustomerAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerCode = new TextBox();
            lblCustomerAddress = new Label();
            lblPhonenumber = new Label();
            lblCustomerName = new Label();
            lblCustomerCode = new Label();
            lblCustomerList = new Label();
            btnBack = new Button();
            gbCustomerManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCustomer).BeginInit();
            gbCustomerInformation.SuspendLayout();
            SuspendLayout();
            // 
            // gbCustomerManager
            // 
            gbCustomerManager.Controls.Add(dtgCustomer);
            gbCustomerManager.Controls.Add(txtSearch);
            gbCustomerManager.Controls.Add(lblSearch);
            gbCustomerManager.Controls.Add(gbCustomerInformation);
            gbCustomerManager.Controls.Add(lblCustomerList);
            gbCustomerManager.Location = new Point(12, 12);
            gbCustomerManager.Name = "gbCustomerManager";
            gbCustomerManager.Size = new Size(776, 389);
            gbCustomerManager.TabIndex = 0;
            gbCustomerManager.TabStop = false;
            gbCustomerManager.Text = "Customer manager";
            // 
            // dtgCustomer
            // 
            dtgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCustomer.Location = new Point(409, 56);
            dtgCustomer.Name = "dtgCustomer";
            dtgCustomer.RowHeadersWidth = 51;
            dtgCustomer.Size = new Size(361, 327);
            dtgCustomer.TabIndex = 2;
            dtgCustomer.CellClick += dtgCustomer_CellClick;
            dtgCustomer.CellDoubleClick += dtgCustomer_CellDoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(630, 23);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(140, 27);
            txtSearch.TabIndex = 1;
            txtSearch.KeyUp += txtSearch_KeyUp;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(571, 26);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // gbCustomerInformation
            // 
            gbCustomerInformation.Controls.Add(btnClear);
            gbCustomerInformation.Controls.Add(btnDelete);
            gbCustomerInformation.Controls.Add(btnAdd);
            gbCustomerInformation.Controls.Add(btnUpdate);
            gbCustomerInformation.Controls.Add(txtCustomerAddress);
            gbCustomerInformation.Controls.Add(txtPhoneNumber);
            gbCustomerInformation.Controls.Add(txtCustomerName);
            gbCustomerInformation.Controls.Add(txtCustomerCode);
            gbCustomerInformation.Controls.Add(lblCustomerAddress);
            gbCustomerInformation.Controls.Add(lblPhonenumber);
            gbCustomerInformation.Controls.Add(lblCustomerName);
            gbCustomerInformation.Controls.Add(lblCustomerCode);
            gbCustomerInformation.Location = new Point(15, 26);
            gbCustomerInformation.Name = "gbCustomerInformation";
            gbCustomerInformation.Size = new Size(388, 357);
            gbCustomerInformation.TabIndex = 0;
            gbCustomerInformation.TabStop = false;
            gbCustomerInformation.Text = "Customer information";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(305, 295);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(77, 56);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(203, 295);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(77, 56);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(8, 295);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(77, 56);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(103, 295);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(77, 56);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Location = new Point(170, 149);
            txtCustomerAddress.Multiline = true;
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.Size = new Size(212, 128);
            txtCustomerAddress.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(170, 112);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(212, 27);
            txtPhoneNumber.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(170, 73);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(212, 27);
            txtCustomerName.TabIndex = 1;
            // 
            // txtCustomerCode
            // 
            txtCustomerCode.Location = new Point(170, 38);
            txtCustomerCode.Name = "txtCustomerCode";
            txtCustomerCode.Size = new Size(212, 27);
            txtCustomerCode.TabIndex = 1;
            // 
            // lblCustomerAddress
            // 
            lblCustomerAddress.AutoSize = true;
            lblCustomerAddress.Location = new Point(23, 152);
            lblCustomerAddress.Name = "lblCustomerAddress";
            lblCustomerAddress.Size = new Size(62, 20);
            lblCustomerAddress.TabIndex = 0;
            lblCustomerAddress.Text = "Address";
            // 
            // lblPhonenumber
            // 
            lblPhonenumber.AutoSize = true;
            lblPhonenumber.Location = new Point(23, 112);
            lblPhonenumber.Name = "lblPhonenumber";
            lblPhonenumber.Size = new Size(108, 20);
            lblPhonenumber.TabIndex = 0;
            lblPhonenumber.Text = "Phone Number";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(23, 73);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(116, 20);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Customer Name";
            // 
            // lblCustomerCode
            // 
            lblCustomerCode.AutoSize = true;
            lblCustomerCode.Location = new Point(23, 40);
            lblCustomerCode.Name = "lblCustomerCode";
            lblCustomerCode.Size = new Size(111, 20);
            lblCustomerCode.TabIndex = 0;
            lblCustomerCode.Text = "Customer Code";
            // 
            // lblCustomerList
            // 
            lblCustomerList.AutoSize = true;
            lblCustomerList.Location = new Point(426, 26);
            lblCustomerList.Name = "lblCustomerList";
            lblCustomerList.Size = new Size(98, 20);
            lblCustomerList.TabIndex = 0;
            lblCustomerList.Text = "Customer List";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(27, 407);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(77, 37);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ManageCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbCustomerManager);
            Controls.Add(btnBack);
            Name = "ManageCustomer";
            Text = "ManageCustomer";
            Load += ManageCustomer_Load;
            gbCustomerManager.ResumeLayout(false);
            gbCustomerManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCustomer).EndInit();
            gbCustomerInformation.ResumeLayout(false);
            gbCustomerInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCustomerManager;
        private GroupBox gbCustomerInformation;
        private Label lblCustomerAddress;
        private Label lblPhonenumber;
        private Label lblCustomerName;
        private Label lblCustomerCode;
        private Label lblSearch;
        private TextBox txtCustomerCode;
        private Label lblCustomerList;
        private DataGridView dtgCustomer;
        private TextBox txtSearch;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtCustomerAddress;
        private TextBox txtPhoneNumber;
        private TextBox txtCustomerName;
        private Button btnAdd;
        private Button btnBack;
    }
}