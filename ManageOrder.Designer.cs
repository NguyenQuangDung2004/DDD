namespace SmartphoneShop
{
    partial class ManageOrder
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
            gbManageOrder = new GroupBox();
            btnBack = new Button();
            dtgManageOrder = new DataGridView();
            gbManageOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgManageOrder).BeginInit();
            SuspendLayout();
            // 
            // gbManageOrder
            // 
            gbManageOrder.Controls.Add(dtgManageOrder);
            gbManageOrder.Location = new Point(11, 10);
            gbManageOrder.Name = "gbManageOrder";
            gbManageOrder.Size = new Size(777, 389);
            gbManageOrder.TabIndex = 0;
            gbManageOrder.TabStop = false;
            gbManageOrder.Text = "Manage Order";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(684, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // dtgManageOrder
            // 
            dtgManageOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgManageOrder.Location = new Point(6, 26);
            dtgManageOrder.Name = "dtgManageOrder";
            dtgManageOrder.RowHeadersWidth = 51;
            dtgManageOrder.Size = new Size(765, 357);
            dtgManageOrder.TabIndex = 0;
            // 
            // ManageOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(gbManageOrder);
            Name = "ManageOrder";
            Text = "ManageOrder";
            gbManageOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgManageOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbManageOrder;
        private DataGridView dtgManageOrder;
        private Button btnBack;
    }
}