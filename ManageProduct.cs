using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartphoneShop
{
    public partial class ManageProduct : Form
    {
        // variable to store the selected product
        private int productId;

        // variable to store the authority level of user, so that we are able to navigate back
        private string authorityLevel;

        // variable to store logged-in userId
        private int userId;

        public ManageProduct(string authorityLevel, int userId)
        {
            this.authorityLevel = authorityLevel;
            this.userId = userId;
            productId = 0;
            InitializeComponent();
        }
        private void LoadCategoryCombobox()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "SELECT CategoryID, CategoryName FROM Category";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cbCategory.DataSource = dataTable;
                cbCategory.DisplayMember = "CategoryName";
                cbCategory.ValueMember = "CategoryID";
            }
        }
        private bool ValidateData(string productCode, string productName, string productPrice, string productQuantity)
        {
            double temp;
            int temp2;
            if (String.IsNullOrEmpty(productName)) { return false; }
            if (String.IsNullOrEmpty(productPrice)) { return false; }
            if (!double.TryParse(productPrice, out temp)) { return false; }
            if (String.IsNullOrEmpty(productQuantity)) { return false; }
            return int.TryParse(productQuantity, out temp2);
        }
        private void UploadFile(string filter, string path)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Optional: Set file filters (e.g., only allow certain file types)
            openFileDialog.Filter = filter;
            // Examples:
            // Text Files (*.txt)|*.txt|
            // Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|
            // All Files (*.*)|*.*|
            // You can combine these options to upload multiple types of data

            // Set title of the dialog
            openFileDialog.Title = "Select a file to upload";

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of the selected file
                string sourceFilePath = openFileDialog.FileName;

                // Specify the target path relative to the project directory
                string targetDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Uploads");

                // Combine the target directory with the file name to get the destination path
                string targetFilePath = Path.Combine(targetDirectory, Path.GetFileName(sourceFilePath));

                try
                {
                    // Ensure the target directory exists
                    if (!Directory.Exists(targetDirectory))
                    {
                        Directory.CreateDirectory(targetDirectory);
                    }

                    // Copy the file to the target directory
                    File.Copy(sourceFilePath, targetFilePath, overwrite: true);

                    txtProductImg.Text = targetFilePath;
                    // Inform the user
                    MessageBox.Show("File uploaded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the file upload
                    MessageBox.Show("Error uploading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadProductData()
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                if (connection != null)
                {
                    connection.Open();
                    string query = "SELECT * FROM Smartphone";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dtgProduct.DataSource = dataTable;
                    }
                }
            }
        }

        private void ClearData()
        {
            FlushProductID();
            txtProductCode.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtProductImg.Text = string.Empty;
            txtProductPrice.Text = string.Empty;
            txtProductQuantity.Text = string.Empty;
            txtSearch.Text = string.Empty;
        }
        private void ChangeButtonStatus(bool buttonStatus)
        {
            //btnUpdate.Enabled = buttonStatus;
            //btnDelete.Enabled = buttonStatus;
            //btnClear.Enabled = buttonStatus;
            //btnAdd.Enabled = buttonStatus;
        }
        private void FlushProductID()
        {
            this.productId = 0;
            ChangeButtonStatus(false);
        }
        private void AddProduct()
        {
            // Open connection by calling the GetConnection function in DatabaseConnection class
            SqlConnection connection = DatabaseConnection.GetConnection();
            // Check connection
            if (connection != null)
            {
                // Open the connection
                connection.Open();

                // Get data input
                string productCode = txtProductCode.Text;
                string productName = txtProductName.Text;
                string productImg = txtProductImg.Text;
                string price = txtProductPrice.Text;
                string quantity = txtProductQuantity.Text;
                int categoryId = Convert.ToInt32(cbCategory.SelectedValue);

                // Validate data
                if (ValidateData(productCode, productName, price, quantity))
                {
                    // Declare query
                    string sql = "INSERT INTO Smartphone VALUES (" +
                        "@productCode, @productName, @productPrice, @productQuantity, @productImg, @categoryId)";

                    // Declare SqlCommand variable to manipulate query
                    SqlCommand command = new SqlCommand(sql, connection);
                    // Add parameters
                    command.Parameters.AddWithValue("@productCode", productCode);
                    command.Parameters.AddWithValue("@productName", productName);
                    command.Parameters.AddWithValue("@productPrice", Convert.ToDouble(price));
                    command.Parameters.AddWithValue("@productQuantity", Convert.ToInt32(quantity));
                    command.Parameters.AddWithValue("@productImg", productImg);
                    command.Parameters.AddWithValue("@categoryId", categoryId);

                    // Execute query and get the result
                    int result = command.ExecuteNonQuery();
                    // Check the result
                    if (result > 0)
                    {
                        MessageBox.Show(
                            "Successfully added new product",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        ClearData();
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Cannot add new product",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }

                // Close the connection
                connection.Close();
            }
        }
        private void UpdateProduct()
        {
            // Open connection by calling the GetConnection function in DatabaseConnection class
            SqlConnection connection = DatabaseConnection.GetConnection();
            // Check connection
            if (connection != null)
            {
                // Open the connection
                connection.Open();

                // Get input data
                string productCode = txtProductCode.Text;
                string productName = txtProductName.Text;
                string productImg = txtProductImg.Text;
                string price = txtProductPrice.Text;
                string quantity = txtProductQuantity.Text;
                int categoryId = Convert.ToInt32(cbCategory.SelectedValue);

                // Validate data
                if (ValidateData(productCode, productName, price, quantity))
                {
                    // Declare query
                    string sql = "UPDATE Smartphone SET SmartphoneCode = @productCode, " +
                        "SmartphoneName = @productName, " +
                        "Price = @productPrice, " +
                        "InventoryQuantity = @productQuantity, " +
                        "SmartphoneImage = @productImg, " +
                        "CategoryID = @categoryId " +
                        "WHERE SmartphoneID = @productId";

                    // Declare SqlCommand variable to manipulate query
                    SqlCommand command = new SqlCommand(sql, connection);
                    // Add parameters
                    command.Parameters.AddWithValue("@productCode", productCode);
                    command.Parameters.AddWithValue("@productName", productName);
                    command.Parameters.AddWithValue("@productPrice", Convert.ToDouble(price));
                    command.Parameters.AddWithValue("@productQuantity", Convert.ToInt32(quantity));
                    command.Parameters.AddWithValue("@productImg", productImg);
                    command.Parameters.AddWithValue("@categoryId", categoryId);
                    command.Parameters.AddWithValue("@productId", this.productId);

                    // Execute query and get the result
                    int result = command.ExecuteNonQuery();
                    // Check result
                    if (result > 0)
                    {
                        MessageBox.Show(
                            "Successfully updated product",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        ClearData();
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Cannot update product",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }

                // Close the connection
                connection.Close();
            }
        }
        private void DeleteProduct()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                if (!IsProductInOrder(this.productId))
                {
                    SqlConnection connection = DatabaseConnection.GetConnection();
                    if (connection != null)
                    {
                        connection.Open();
                        string sql = "DELETE FROM Smartphone WHERE SmartphoneID = @productId";
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@productId", this.productId);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Successfully delete product", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearData();
                            LoadProductData();
                        }
                        else
                        {
                            MessageBox.Show("Cannot delete product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Product is in another order & cannot delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool IsProductInOrder(int productId)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string sql = "SELECT COUNT(*) FROM SaleDetail WHERE SmartphoneID = @productId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("productId", productId);
                int result = (int)command.ExecuteScalar();
                connection.Close();
                return result > 0;
            }
            return false;
        }
        private void SearchProduct(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                LoadProductData();
            }
            else
            {
                // Open connection by calling the GetConnection function in DatabaseConnection class
                SqlConnection connection = DatabaseConnection.GetConnection();
                // Check connection
                if (connection != null)
                {
                    // Open the connection
                    connection.Open();

                    // Declare query to the database
                    string sql = "SELECT p.SmartphoneID, p.SmartphoneCode, p.SmartphoneName, p.Price, " +
                                 "p.InventoryQuantity, p.SmartphoneImage, c.CategoryName " +
                                 "FROM Smartphone p " +
                                 "INNER JOIN Category c " +
                                 "ON p.CategoryID = c.CategoryID " +
                                 "WHERE p.SmartphoneCode LIKE @search " +
                                 "OR p.SmartphoneName LIKE @search " +
                                 "OR c.CategoryName LIKE @search";

                    // Initialize SqlDataAdapter to translate query result to a data table
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    // Add params to query
                    adapter.SelectCommand.Parameters.AddWithValue("search", "%" + search + "%");

                    // Initialize data table
                    DataTable data = new DataTable();
                    // Fill data table with data queried from database
                    adapter.Fill(data);
                    // Set the data source for data table
                    dtgProduct.DataSource = data;

                    // Close the connection
                    connection.Close();
                }
            }
        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            LoadProductData();
            LoadCategoryCombobox();
            ChangeButtonStatus(false);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            UploadFile("ImageFiles (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png", "/Upload");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        { 
                switch (authorityLevel)
                {
                    case "Admin":
                        {
                            AdminForm adminForm = new AdminForm(this.authorityLevel, this.userId);
                            this.Hide();
                            adminForm.Show();
                            break;
                        }
                    case "Warehouse Manager":
                        {
                            WarehouseManagerForm warehouseManagerForm = new WarehouseManagerForm(this.authorityLevel, this.userId);
                            this.Hide();
                            warehouseManagerForm.Show();
                            break;
                        }
                    case "Sale":
                        {
                            SaleForm saleForm = new SaleForm(this.authorityLevel, this.userId);
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

        private void btnManageCategory_Click(object sender, EventArgs e)
        {
            //ManageCategory manageCategory = new ManageCategory(this.authorityLevel, this.employeeId);
            //this.Hide();
            //manageCategory.Show();
        }

        private void dtgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get row index based on current cell (cell clicked)
            int index = dtgProduct.CurrentCell.RowIndex;
            // Check index
            if (index == -1 || dtgProduct.Rows[index].IsNewRow)
            {
                return;
            }

            // Get value of each cell based on row index
            // You have to check the SQL query which is used to load data from database (LoadProductData function)
            // Use this query and execute it in SSMS to imagine the dataGridView
            // The order of the column header is as follows:
            // ID | ProductCode | ProductName | Price | InventoryQuantity | ProductImage | CategoryName
            // And the index is from 0 to 6

            // Get the ProductID (index is 0)
            productId = Convert.ToInt32(dtgProduct.Rows[index].Cells[0].Value);

            // Change the button status by true (update, delete, clear is enabled when productId is assigned with value > 0)
            ChangeButtonStatus(true);

            // Get the ProductCode (index is 1)
            txtProductCode.Text = dtgProduct.Rows[index].Cells[1].Value.ToString();

            // Get the ProductName (index is 2)
            txtProductName.Text = dtgProduct.Rows[index].Cells[2].Value.ToString();

            // Get the ProductPrice (index is 3)
            txtProductPrice.Text = dtgProduct.Rows[index].Cells[3].Value.ToString();

            // Get the ProductQuantity (index is 4)
            txtProductQuantity.Text = dtgProduct.Rows[index].Cells[4].Value.ToString();

            // Get the ProductImage (index is 5)
            txtProductImg.Text = dtgProduct.Rows[index].Cells[5].Value.ToString();

            // Get the CategoryName (index is 6) and check in combobox to select the equal value
            string categoryName = dtgProduct.Rows[index].Cells[6].Value.ToString();

            cbCategory.SelectedValue = dtgProduct.Rows[index].Cells[6].Value;

            for (int i = 0; i < cbCategory.Items.Count; i++)
            {
                if (cbCategory.Items[i].ToString() == categoryName)
                {
                    cbCategory.SelectedIndex = i;
                    break;
                }
            }
        }


        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearch.Text;
            SearchProduct(search);
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            ManageProduct manageProduct = new ManageProduct(this.authorityLevel, this.userId);
            this.Hide();
            manageProduct.Show();
        }
    }
}
