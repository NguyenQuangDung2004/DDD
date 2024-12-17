using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneShop
{
    public class DatabaseConnection
    {
        private static string _connectionString = "Data Source=ACER\\SQLEXPRESS02;" +
            "Initial Catalog = SMARTPHONE_MANAGEMENT_SE07203; " +
            "Integrated Security = True; Encrypt=True;" +
            "Trust Server Certificate=True";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(_connectionString);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Error while connecting to the database",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            return connection;
        }
    }
}

