using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartphoneShop
{
    public partial class SaleForm : Form
    {
        int employeeID;
        string authorityLevel;
        public SaleForm(string authorityLevel, int employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            this.authorityLevel = authorityLevel;
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            ManageCustomer manageCustomer = new ManageCustomer(authorityLevel, employeeID);
            this.Hide();
            manageCustomer.Show();
        }

        private void btnManageOrder_Click(object sender, EventArgs e)
        {
                OrderHistory orderHistory = new OrderHistory(this.authorityLevel, this.employeeID);
                this.Hide();
                orderHistory.Show();
        }
    }
}