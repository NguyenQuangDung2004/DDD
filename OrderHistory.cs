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
    public partial class OrderHistory : Form
    {
        private int employeeID;
        private string authorityLevel;
        public OrderHistory(string authorityLevel, int employeeID) : this(authorityLevel)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            this.authorityLevel = authorityLevel; 
        }

        public OrderHistory(string authorityLevel)
        {
            this.authorityLevel = authorityLevel;
        }

        private void LoadOrderHistory()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = @"SELECT o.SaleDate, e.employeeName, c.CustomerName AS CustomerName FROM Sale o
                                 INNER JOIN employee e ON o.employeeID = e.employeeID
                                 INNER JOIN Customer c ON o.CustomerID = c.CustomerID
                                 WHERE o.employeeID = @employeeID
                                 GROUP BY o.SaleDate, e.employeeName, e.employeeCode, c.CustomerName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("employeeID", employeeID);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgOrderHistory.DataSource = dataTable;
            }
        }
        private void RedirectPage()
        {
            switch (this.authorityLevel)
            {
                case "Admin":
                    {
                        AdminForm adminForm = new AdminForm(authorityLevel, employeeID);
                        this.Hide();
                        adminForm.Show();
                        break;
                    }
                case "Warehouse Manager": 
                    {
                        WarehouseManagerForm warehouseManagerForm = new WarehouseManagerForm(authorityLevel, employeeID);
                        this.Hide();
                        warehouseManagerForm.Show(); 
                        break;
                    }
                case "Sale":
                    {
                        SaleForm saleForm = new SaleForm(authorityLevel, employeeID);
                        this.Hide();
                        saleForm.Show();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {
            LoadOrderHistory();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RedirectPage();
        }
                private void btnManageOrder_Click(object sender, EventArgs e)
        {
                OrderHistory orderHistory = new OrderHistory(this.authorityLevel, this.employeeID);
                this.Hide();
                orderHistory.Show();
        }
    }
}
