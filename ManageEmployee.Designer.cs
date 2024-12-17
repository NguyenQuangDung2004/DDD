namespace SmartphoneShop
{
    partial class ManageEmployee
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
            gbManageEmployee = new GroupBox();
            dtgEmployee = new DataGridView();
            txtSearch = new TextBox();
            lblEmployeeList = new Label();
            gbEmployeeInformation = new GroupBox();
            txtEmployeeCode = new TextBox();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            cbAuthorityLevel = new ComboBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtEmployeePosition = new TextBox();
            txtEmployeeName = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblAuthorityLevel = new Label();
            lblPosition = new Label();
            lblEmployeeName = new Label();
            lblEmployeeCode = new Label();
            btnBack = new Button();
            gbManageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgEmployee).BeginInit();
            gbEmployeeInformation.SuspendLayout();
            SuspendLayout();
            // 
            // gbManageEmployee
            // 
            gbManageEmployee.Controls.Add(dtgEmployee);
            gbManageEmployee.Controls.Add(txtSearch);
            gbManageEmployee.Controls.Add(lblEmployeeList);
            gbManageEmployee.Controls.Add(gbEmployeeInformation);
            gbManageEmployee.Location = new Point(12, 12);
            gbManageEmployee.Name = "gbManageEmployee";
            gbManageEmployee.Size = new Size(776, 375);
            gbManageEmployee.TabIndex = 0;
            gbManageEmployee.TabStop = false;
            gbManageEmployee.Text = "Manage Employee";
            // 
            // dtgEmployee
            // 
            dtgEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEmployee.Location = new Point(319, 62);
            dtgEmployee.Name = "dtgEmployee";
            dtgEmployee.RowHeadersWidth = 51;
            dtgEmployee.Size = new Size(451, 294);
            dtgEmployee.TabIndex = 5;
            dtgEmployee.CellClick += dtgEmployee_CellClick;
            dtgEmployee.KeyUp += txtSearch_KeyUp;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(511, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(231, 27);
            txtSearch.TabIndex = 4;
            // 
            // lblEmployeeList
            // 
            lblEmployeeList.AutoSize = true;
            lblEmployeeList.Location = new Point(393, 25);
            lblEmployeeList.Name = "lblEmployeeList";
            lblEmployeeList.Size = new Size(101, 20);
            lblEmployeeList.TabIndex = 0;
            lblEmployeeList.Text = "Employee List";
            // 
            // gbEmployeeInformation
            // 
            gbEmployeeInformation.Controls.Add(txtEmployeeCode);
            gbEmployeeInformation.Controls.Add(btnClear);
            gbEmployeeInformation.Controls.Add(btnUpdate);
            gbEmployeeInformation.Controls.Add(btnDelete);
            gbEmployeeInformation.Controls.Add(btnAdd);
            gbEmployeeInformation.Controls.Add(cbAuthorityLevel);
            gbEmployeeInformation.Controls.Add(txtPassword);
            gbEmployeeInformation.Controls.Add(txtUsername);
            gbEmployeeInformation.Controls.Add(txtEmployeePosition);
            gbEmployeeInformation.Controls.Add(txtEmployeeName);
            gbEmployeeInformation.Controls.Add(lblPassword);
            gbEmployeeInformation.Controls.Add(lblUsername);
            gbEmployeeInformation.Controls.Add(lblAuthorityLevel);
            gbEmployeeInformation.Controls.Add(lblPosition);
            gbEmployeeInformation.Controls.Add(lblEmployeeName);
            gbEmployeeInformation.Controls.Add(lblEmployeeCode);
            gbEmployeeInformation.Location = new Point(11, 25);
            gbEmployeeInformation.Name = "gbEmployeeInformation";
            gbEmployeeInformation.Size = new Size(288, 331);
            gbEmployeeInformation.TabIndex = 0;
            gbEmployeeInformation.TabStop = false;
            gbEmployeeInformation.Text = "Employee Information";
            // 
            // txtEmployeeCode
            // 
            txtEmployeeCode.Location = new Point(112, 37);
            txtEmployeeCode.Name = "txtEmployeeCode";
            txtEmployeeCode.Size = new Size(153, 27);
            txtEmployeeCode.TabIndex = 4;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Control;
            btnClear.Location = new Point(173, 296);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(173, 243);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 296);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 243);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbAuthorityLevel
            // 
            cbAuthorityLevel.FormattingEnabled = true;
            cbAuthorityLevel.Location = new Point(112, 133);
            cbAuthorityLevel.Name = "cbAuthorityLevel";
            cbAuthorityLevel.Size = new Size(155, 28);
            cbAuthorityLevel.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(112, 194);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(155, 27);
            txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(112, 163);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(155, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtEmployeePosition
            // 
            txtEmployeePosition.Location = new Point(112, 101);
            txtEmployeePosition.Name = "txtEmployeePosition";
            txtEmployeePosition.Size = new Size(155, 27);
            txtEmployeePosition.TabIndex = 1;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(112, 70);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(155, 27);
            txtEmployeeName.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(18, 194);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(18, 165);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblAuthorityLevel
            // 
            lblAuthorityLevel.AutoSize = true;
            lblAuthorityLevel.Location = new Point(17, 136);
            lblAuthorityLevel.Name = "lblAuthorityLevel";
            lblAuthorityLevel.Size = new Size(39, 20);
            lblAuthorityLevel.TabIndex = 0;
            lblAuthorityLevel.Text = "Role";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(18, 104);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(61, 20);
            lblPosition.TabIndex = 0;
            lblPosition.Text = "Position";
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Location = new Point(18, 70);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(76, 20);
            lblEmployeeName.TabIndex = 0;
            lblEmployeeName.Text = "Full Name";
            // 
            // lblEmployeeCode
            // 
            lblEmployeeCode.AutoSize = true;
            lblEmployeeCode.Location = new Point(18, 37);
            lblEmployeeCode.Name = "lblEmployeeCode";
            lblEmployeeCode.Size = new Size(44, 20);
            lblEmployeeCode.TabIndex = 0;
            lblEmployeeCode.Text = "Code";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(17, 393);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 45);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ManageEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbManageEmployee);
            Controls.Add(btnBack);
            Name = "ManageEmployee";
            Text = "ManageEmployee";
            Load += ManageEmployee_Load;
            gbManageEmployee.ResumeLayout(false);
            gbManageEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgEmployee).EndInit();
            gbEmployeeInformation.ResumeLayout(false);
            gbEmployeeInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbManageEmployee;
        private GroupBox gbEmployeeInformation;
        private Label lblEmployeeList;
        private TextBox txtEmployeePosition;
        private TextBox txtEmployeeName;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblAuthorityLevel;
        private Label lblPosition;
        private Label lblEmployeeName;
        private Label lblEmployeeCode;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private ComboBox cbAuthorityLevel;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnBack;
        private DataGridView dtgEmployee;
        private TextBox txtSearch;
        private TextBox txtEmployeeCode;
    }
}