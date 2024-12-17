namespace SmartphoneShop
{
    public partial class WarehouseManagerForm : Form
    {
        int employeeID;
        string authorityLevel;
        public WarehouseManagerForm(string authorityLevel, int employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            this.authorityLevel = authorityLevel;
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            ManageProduct manageProduct = new ManageProduct(authorityLevel, employeeID);
            this.Hide();
            manageProduct.Show();
        }
    }
}
