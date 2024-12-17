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
    public partial class ManageOrder : Form
    {
        private int employeeID;
        private string authorityLevel;
        public ManageOrder(string authorityLevel, int employeeID) : this(authorityLevel)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            this.authorityLevel = authorityLevel;
        }

        public ManageOrder(string authorityLevel)
        {
            this.authorityLevel = authorityLevel;
        }

        private void LoadOrderHistory()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "SELECT o.ImportDate, e.employeeName, c.CustomerName " +
                    "FROM Import o INNER JOIN employee e ON o.employeeID = e.employeeID  " +
                    "INNER JOIN Customer c ON o.CustomerID = c.CustomerID " +
                    "WHERE o.employeeID = @employeeID " +
                    "GROUP BY o.ImportDate, e.employeeName, e.employeeCode";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("employeeID", employeeID);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgManageOrder.DataSource = dataTable;
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

        private void ManageOrder_Load(object sender, EventArgs e)
        {
            LoadOrderHistory();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RedirectPage();
        }
        private void btnManageOrder_Click(object sender, EventArgs e)
        {
            ManageOrder ManageOrder = new ManageOrder(this.authorityLevel, this.employeeID);
            this.Hide();
            ManageOrder.Show();
        }
    }
}
