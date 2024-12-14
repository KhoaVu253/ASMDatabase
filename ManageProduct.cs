using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Data;

namespace Glocery_Shop
{
    public partial class ManageProduct : Form
    {
        // variable to store the selected product
        private int productId;

        // variable to store the authority level of user, so that we are able to navigate back
        private string authorityLevel;

        // variable to store logged in userid
        private int userId;
        private Dictionary<int, string> categoryDictionary = new Dictionary<int, string>();

        private string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int EmployeeId { get; private set; }

        public ManageProduct(string authorityLevel, int userId)
        {
            this.authorityLevel = authorityLevel;
            this.userId = userId;
            productId = 0;
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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

                categoryDictionary.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    int categoryID = (int)row["CategoryID"];
                    string categoryName = row["CategoryName"].ToString();
                    categoryDictionary[categoryID] = categoryName;
                }

                cbCategory.DataSource = dataTable;
                cbCategory.DisplayMember = "CategoryName";
                cbCategory.ValueMember = "CategoryID";

                cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
                cbCategory.MaxDropDownItems = 5;
            }
        }

        private void SelectCategoryInComboBox(int categoryID)
        {
            if (categoryDictionary.ContainsKey(categoryID))
            {
                string categoryName = categoryDictionary[categoryID];

                for (int i = 0; i < cbCategory.Items.Count; i++)
                {
                    if ((string)cbCategory.GetItemText(cbCategory.Items[i]) == categoryName)
                    {
                        cbCategory.SelectedIndex = i;
                        break;
                    }
                }
            }
        }


        private bool ValidateData(string productCode,
                          string productName,
                          string productPrice,
                          string productQuantity)
        {
            double temp;
            int temp2;

            if (string.IsNullOrEmpty(productName)) { return false; }
            if (string.IsNullOrEmpty(productPrice) || !double.TryParse(productPrice, out temp)) { return false; }
            if (string.IsNullOrEmpty(productQuantity) || !int.TryParse(productQuantity, out temp2)) { return false; }

            return int.TryParse(productQuantity, out temp2);
        }
        
        private void LoadProductData()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "SELECT * FROM Product";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dvgProduct.DataSource = dataTable;
                connection.Close();
            }
        }
        private void ClearData()
        {
            FlushProductId();
            txtProductCode.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtProductImg.Text = string.Empty;
            txtProductPrice.Text = string.Empty;
            txtProductQuantity.Text = string.Empty;
            txtSearch.Text = string.Empty;
        }
        private void ChangeButtonStatus(bool buttonStatus)
        {
            // When employee is selected, button add will be disabled
            // button Update, Delete & Clear will be enabled and vice versa

            btnUpdate.Enabled = buttonStatus;
            btnDelete.Enabled = buttonStatus;
            btnClear.Enabled = buttonStatus;
            btnAdd.Enabled = !buttonStatus;
        }
        private void FlushProductId()
        {
            this.productId = 0;
            ChangeButtonStatus(false);
        }

        private void AddProduct()
        {
            // Open connection by call the GetConnection function in DatabaseConnection class
            SqlConnection connection = DatabaseConnection.GetConnection();

            // Check connection
            if (connection != null)
            {
                // Open the connection
                connection.Open();

                // Get data from Input
                string productCode = txtProductCode.Text;
                string productName = txtProductName.Text;
                string productImg = txtProductImg.Text;
                string price = txtProductPrice.Text;
                string quantity = txtProductQuantity.Text;
                int categoryId = Convert.ToInt32(cbCategory.SelectedValue);

                // Validate data
                if (ValidateData(productCode, productName, price, quantity))
                {
                    // declare query
                    string sql = "INSERT INTO Product VALUES (@productCode, @productName, @productPrice, @productQuantity, @productImg, @categoryId)";

                    // declare sqlcommand variable to manipulate query
                    SqlCommand command = new SqlCommand(sql, connection);

                    // add params
                    command.Parameters.AddWithValue("@productCode", productCode);
                    command.Parameters.AddWithValue("@productName", productName);
                    command.Parameters.AddWithValue("@productPrice", Convert.ToDouble(price));
                    command.Parameters.AddWithValue("@productQuantity", Convert.ToInt32(quantity));
                    command.Parameters.AddWithValue("@productImg", productImg);
                    command.Parameters.AddWithValue("@categoryId", categoryId);

                    // execute query and get the result
                    int result = command.ExecuteNonQuery();

                    // check the result
                    if (result > 0)
                    {
                        MessageBox.Show(
                            "Successfully add new product",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ClearData();
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Cannot add new product",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }

                // close the connection
                connection.Close();
            }
        }

        private void UpdateProduct()
        {
            // Open connection by call the GetConnection function in DatabaseConnection class
            SqlConnection connection = DatabaseConnection.GetConnection();

            // Check connection
            if (connection != null)
            {
                // Open the connection
                connection.Open();

                // get Input data
                string productCode = txtProductCode.Text;
                string productName = txtProductName.Text;
                string productImg = txtProductImg.Text;
                string price = txtProductPrice.Text;
                string quantity = txtProductQuantity.Text;
                int categoryId = Convert.ToInt32(cbCategory.SelectedValue);

                // validate data
                if (ValidateData(productCode, productName, price, quantity))
                {
                    // declare query
                    string sql = "UPDATE Product SET ProductCode = @productCode," +
                                 "ProductName = @productName," +
                                 "Price = @productPrice," +
                                 "InventoryQuantity = @productQuantity," +
                                 "ProductImage = @productImg," +
                                 "CategoryID = @categoryId" +
                                 " WHERE ProductID = @productId";

                    // declare sqlcommand variable to manipulate query
                    SqlCommand command = new SqlCommand(sql, connection);

                    // add params
                    command.Parameters.AddWithValue("@productCode", productCode);
                    command.Parameters.AddWithValue("@productName", productName);
                    command.Parameters.AddWithValue("@productPrice", Convert.ToDouble(price));
                    command.Parameters.AddWithValue("@productQuantity", Convert.ToInt32(quantity));
                    command.Parameters.AddWithValue("@productImg", productImg);
                    command.Parameters.AddWithValue("@categoryId", categoryId);
                    command.Parameters.AddWithValue("@productId", this.productId);

                    // execute query and get the result
                    int result = command.ExecuteNonQuery();

                    // check result
                    if (result > 0)
                    {
                        MessageBox.Show(
                            "Successfully update product",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ClearData();
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Cannot update product",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }

                // close the connection
                connection.Close();
            }
        }
        private void DeleteProduct()
        {
            // Ask for confirmation
            DialogResult dialogResult = MessageBox.Show("Do you want to delete the product?",
                                                        "Warning",
                                                        MessageBoxButtons.YesNoCancel,
                                                        MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                // Check if product in any order
                // If it have, deny this action because this can cause exception while running
                if (!IsProductInOrder(this.productId))
                {
                    // Open connection by call the GetConnection function in DatabaseConnection class
                    SqlConnection connection = DatabaseConnection.GetConnection();

                    // Check connection
                    if (connection != null)
                    {
                        // Open the connection
                        connection.Open();

                        // declare query
                        string sql = "DELETE FROM Product WHERE ProductID = @productId";

                        // declare sqlcommand variable to manipulate query
                        SqlCommand command = new SqlCommand(sql, connection);

                        // add params
                        command.Parameters.AddWithValue("@productId", this.productId);

                        // execute query and get the result
                        int result = command.ExecuteNonQuery();

                        // check result
                        if (result > 0)
                        {
                            MessageBox.Show(
                                "Successfully delete product",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ClearData();
                            LoadProductData();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Cannot delete product",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }

                        // close the connection
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Product is in another order. Cannot delete",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        private bool IsProductInOrder(int productId)
        {
            // Open connection by call the GetConnection function in DatabaseConnection class
            SqlConnection connection = DatabaseConnection.GetConnection();

            // Check connection
            if (connection != null)
            {
                // Open the connection
                connection.Open();

                // declare query to get number of record have productid equal productId
                string sql = "SELECT COUNT(*) FROM OrderDetail WHERE ProductID = @productId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@productId", productId);

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
                // Open connection by call the GetConnection function in DatabaseConnection class
                SqlConnection connection = DatabaseConnection.GetConnection();

                // Check connection
                if (connection != null)
                {
                    // Open the connection
                    connection.Open();

                    // Declare query to the database
                    string sql = "SELECT p.ProductID, p.ProductCode, p.ProductName, p.Price, " +
                                "p.InventoryQuantity, p.ProductImage, c.CategoryName " +
                                "FROM Product p " +
                                "INNER JOIN Category c ON p.CategoryID = c.CategoryID " +
                                "WHERE p.ProductCode LIKE @search " +
                                "OR p.ProductName LIKE @search " +
                                "OR c.CategoryName LIKE @search";

                    // Initialize SqlDataAdapter to translate query result to a data table
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                    // Add params to query
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");

                    // Initialize data table
                    DataTable data = new DataTable();

                    // Fill datatable with data queried from database
                    adapter.Fill(data);

                    // Set the data source for data table
                    dvgProduct.DataSource = data;

                    // Close the connection
                    connection.Close();
                }
            }
        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            // binding data to the data gridview
            LoadProductData();

            // binding data to combobox
            LoadCategoryCombobox();

            // set status for button to ensure the UX of user
            ChangeButtonStatus(false);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            UploadFile("Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png");
        }

        private void UploadFile(string fileFilter)
        {
            try
            {
                // Mở hộp thoại chọn tệp
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = fileFilter;
                    openFileDialog.Title = "Select an image file";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Lấy đường dẫn file gốc
                        string sourceFilePath = openFileDialog.FileName;

                        // Đường dẫn thư mục "Images" trong thư mục dự án

                        string imagesFolder = Path.Combine(projectDirectory, "Images");

                        // Tạo thư mục nếu chưa tồn tại
                        if (!Directory.Exists(imagesFolder))
                        {
                            Directory.CreateDirectory(imagesFolder);
                        }

                        // Tạo đường dẫn file đích trong thư mục Images
                        string fileName = Path.GetFileName(sourceFilePath);
                        string destinationFilePath = Path.Combine(imagesFolder, fileName);

                        // Sao chép file vào thư mục Images
                        File.Copy(sourceFilePath, destinationFilePath, overwrite: true);

                        // Thông báo thành công
                        MessageBox.Show($"File uploaded successfully to: {destinationFilePath}",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        pictureBox1.ImageLocation = destinationFilePath;
                        txtProductImg.Text = fileName;
                    }
                }
            }
            catch (Exception ex)
            {
                // Thông báo lỗi
                MessageBox.Show($"An error occurred: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
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
                    AdminForm adminForm = new AdminForm(this.authorityLevel, this.userId);
                    this.Hide();
                    adminForm.Show();
                    break;

                case "Warehouse Manager":
                    WarehouseManagerForm warehouseManagerForm = new WarehouseManagerForm(this.authorityLevel, this.userId);
                    this.Hide();
                    warehouseManagerForm.Show();
                    break;

                case "Sale":
                    SaleForm saleForm = new SaleForm(this.authorityLevel, this.userId);
                    this.Hide();
                    saleForm.Show();
                    break;

                default:
                    break;
            }
        }


        private void btnManageCategory_Click(object sender, EventArgs e)
        {
            ManageCategory manageCategory = new ManageCategory(this.authorityLevel, this.EmployeeId);
            manageCategory.Show();
        }

        private void dvgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dvgProduct.CurrentRow.Index;

            // Check if index is valid
            if (rowIndex >= 0 && rowIndex < dvgProduct.Rows.Count)
            {
                // Get the value of each cell based on which row is used to load data from database (LoadProductData function)
                // This query and the value 500 is hardcode, tag the product view
                // The order of the column is ID | ProductCode | ProductName | Price | InventoryQuantity | ProductManager | CategoryName

                // Change button status to true (update, delete, clear) is enable when productId is assigned with value > 0
                ChangeButtonStatus(true);

                productId = Convert.ToInt32( dvgProduct.Rows[rowIndex].Cells[0].Value);
                // Get the ProductCode
                txtProductCode.Text = dvgProduct.Rows[rowIndex].Cells[1].Value.ToString();

                // Get the ProductName
                txtProductName.Text = dvgProduct.Rows[rowIndex].Cells[2].Value.ToString();

                // Get the ProductPrice
                txtProductPrice.Text = dvgProduct.Rows[rowIndex].Cells[3].Value.ToString();

                // Get the ProductQuantity
                txtProductQuantity.Text = dvgProduct.Rows[rowIndex].Cells[4].Value.ToString();

                // Get the ProductImage
                txtProductImg.Text = dvgProduct.Rows[rowIndex].Cells[5].Value.ToString();

                // Get the CategoryName and check the combobox to select the equal value
                int categoryId = (int)dvgProduct.Rows[rowIndex].Cells[6].Value;

                // Use the SelectCategoryInComboBox method to select the category in ComboBox
                SelectCategoryInComboBox(categoryId);
                string imagesFolder = Path.Combine(projectDirectory, "Images");
                pictureBox1.ImageLocation = Path.Combine(imagesFolder, txtProductImg.Text);
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearch.Text;
            SearchProduct(search);
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            ManageProduct manageProduct = new ManageProduct(this.authorityLevel, this.EmployeeId);
            this.Hide();
            manageProduct.Show();
        }

        private class ManageCategory
        {
            public ManageCategory(string authorityLevel, int employeeId)
            {
                AuthorityLevel = authorityLevel;
                EmployeeId = employeeId;
            }

            public string AuthorityLevel { get; }
            public int EmployeeId { get; }

            internal void Show()
            {
                throw new NotImplementedException();
            }
        }
    }
}
