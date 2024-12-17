namespace SmartphoneShop
{
    partial class OrderHistory
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
            gbPurchaseHistory = new GroupBox();
            dtgOrderHistory = new DataGridView();
            btnBack = new Button();
            gbPurchaseHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgOrderHistory).BeginInit();
            SuspendLayout();
            // 
            // gbPurchaseHistory
            // 
            gbPurchaseHistory.Controls.Add(btnBack);
            gbPurchaseHistory.Controls.Add(dtgOrderHistory);
            gbPurchaseHistory.Location = new Point(12, 12);
            gbPurchaseHistory.Name = "gbPurchaseHistory";
            gbPurchaseHistory.Size = new Size(776, 426);
            gbPurchaseHistory.TabIndex = 0;
            gbPurchaseHistory.TabStop = false;
            gbPurchaseHistory.Text = "Purchase history";
            // 
            // dtgOrderHistory
            // 
            dtgOrderHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgOrderHistory.Location = new Point(11, 23);
            dtgOrderHistory.Name = "dtgOrderHistory";
            dtgOrderHistory.RowHeadersWidth = 51;
            dtgOrderHistory.Size = new Size(759, 362);
            dtgOrderHistory.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(660, 391);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(110, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // OrderHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbPurchaseHistory);
            Name = "OrderHistory";
            Text = "OrderHistory";
            Load += OrderHistory_Load;
            gbPurchaseHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgOrderHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbPurchaseHistory;
        private Button btnBack;
        private DataGridView dtgOrderHistory;
    }
}