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
    public partial class AdminForm : Form
    {
        int userID;
        int employeeID;
        string authorityLevel;
        public AdminForm(string authorityLevel, int employeeID)
        {
            InitializeComponent();
            this.authorityLevel = authorityLevel;
            this.employeeID = employeeID;
            this.userID = userID;
        }
        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            ManageEmployee manageEmployee = new ManageEmployee(authorityLevel);
            this.Hide();
            manageEmployee.Show();
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            ManageProduct manageProduct = new ManageProduct(authorityLevel, userID);
            this.Hide();
            manageProduct.Show();
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

