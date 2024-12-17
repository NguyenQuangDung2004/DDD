namespace SmartphoneShop
{
    partial class AdminForm
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
            gbAdminFeature = new GroupBox();
            btnManageProduct = new Button();
            btnManageOrder = new Button();
            btnManageCustomer = new Button();
            btnManageEmployee = new Button();
            gbAdminFeature.SuspendLayout();
            SuspendLayout();
            // 
            // gbAdminFeature
            // 
            gbAdminFeature.Controls.Add(btnManageProduct);
            gbAdminFeature.Controls.Add(btnManageOrder);
            gbAdminFeature.Controls.Add(btnManageCustomer);
            gbAdminFeature.Controls.Add(btnManageEmployee);
            gbAdminFeature.Location = new Point(12, 12);
            gbAdminFeature.Name = "gbAdminFeature";
            gbAdminFeature.Size = new Size(776, 426);
            gbAdminFeature.TabIndex = 0;
            gbAdminFeature.TabStop = false;
            gbAdminFeature.Text = " Admin Feature";
            // 
            // btnManageProduct
            // 
            btnManageProduct.Location = new Point(428, 44);
            btnManageProduct.Name = "btnManageProduct";
            btnManageProduct.Size = new Size(332, 99);
            btnManageProduct.TabIndex = 0;
            btnManageProduct.Text = "Manage Product";
            btnManageProduct.UseVisualStyleBackColor = true;
            btnManageProduct.Click += btnManageProduct_Click;
            // 
            // btnManageOrder
            // 
            btnManageOrder.Location = new Point(427, 169);
            btnManageOrder.Name = "btnManageOrder";
            btnManageOrder.Size = new Size(333, 98);
            btnManageOrder.TabIndex = 0;
            btnManageOrder.Text = "Manage Order";
            btnManageOrder.UseVisualStyleBackColor = true;
            btnManageOrder.Click += btnManageOrder_Click;
            // 
            // btnManageCustomer
            // 
            btnManageCustomer.Location = new Point(27, 169);
            btnManageCustomer.Name = "btnManageCustomer";
            btnManageCustomer.Size = new Size(343, 98);
            btnManageCustomer.TabIndex = 0;
            btnManageCustomer.Text = "Manage Customer";
            btnManageCustomer.UseVisualStyleBackColor = true;
            btnManageCustomer.Click += btnManageCustomer_Click;
            // 
            // btnManageEmployee
            // 
            btnManageEmployee.Location = new Point(27, 44);
            btnManageEmployee.Name = "btnManageEmployee";
            btnManageEmployee.Size = new Size(343, 99);
            btnManageEmployee.TabIndex = 0;
            btnManageEmployee.Text = "Manage Employee";
            btnManageEmployee.UseVisualStyleBackColor = true;
            btnManageEmployee.Click += btnManageEmployee_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbAdminFeature);
            Name = "AdminForm";
            Text = "AdminForm";
            gbAdminFeature.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAdminFeature;
        private Button btnManageProduct;
        private Button btnManageCustomer;
        private Button btnManageEmployee;
        private Button btnManageOrder;
    }
}