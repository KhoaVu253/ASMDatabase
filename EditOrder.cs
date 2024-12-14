using Microsoft.Data.SqlClient;
using System.Data;

namespace Glocery_Shop
{
    public partial class EditOrder : Form
    {
        int employeeId = 0;
        int productId = 0;
        int orderId = 0;

        public event EventHandler OrderEdited;

        public EditOrder(int orderId)
        {
            InitializeComponent();
            InitializeOrderDetailGrid();
            this.orderId = orderId;
        }

        private void EditOrder_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadProducts();
            LoadOrderDetails();
            LoadOrderDetailData();

            txtEmployeeID.ReadOnly = true;
        }

        private void LoadCustomers()
        {
            try
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection != null)
                {
                    connection.Open();
                    string query = "SELECT CustomerID, CustomerName FROM Customer";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    cbxCustomer.DataSource = dataTable;
                    cbxCustomer.DisplayMember = "CustomerName";
                    cbxCustomer.ValueMember = "CustomerID";
                    cbxCustomer.DropDownStyle = ComboBoxStyle.DropDownList;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProducts()
        {
            try
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection != null)
                {
                    connection.Open();
                    string query = @"
                SELECT ProductID, ProductCode, ProductName, InventoryQuantity 
                FROM Product
                WHERE InventoryQuantity > 0";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvProduct.DataSource = dataTable;

                    dgvProduct.Columns["ProductID"].HeaderText = "ID";
                    dgvProduct.Columns["ProductCode"].HeaderText = "Mã sản phẩm";
                    dgvProduct.Columns["ProductName"].HeaderText = "Tên sản phẩm";
                    dgvProduct.Columns["InventoryQuantity"].HeaderText = "Số lượng tồn";

                    dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOrderDetails()
        {
            try
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection != null)
                {
                    connection.Open();

                    string query = @"
                SELECT o.OrderDate, 
                       o.EmployeeID, 
                       o.CustomerID
                FROM Orders o
                WHERE o.OrderID = @orderId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@orderId", orderId);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        DateTime orderDate = reader.GetDateTime(reader.GetOrdinal("OrderDate"));
                        int employeeIdFromDb = reader.GetInt32(reader.GetOrdinal("EmployeeID"));
                        int customerId = reader.GetInt32(reader.GetOrdinal("CustomerID"));

                        dtpOrderDate.Value = orderDate;
                        txtEmployeeID.Text = employeeIdFromDb.ToString();
                        cbxCustomer.SelectedValue = customerId;

                        employeeId = employeeIdFromDb;
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading order details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOrderDetailData()
        {
            try
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection != null)
                {
                    connection.Open();

                    string query = @"
                SELECT od.ProductID, 
                       p.ProductCode, 
                       p.ProductName, 
                       od.QuantitySolid
                FROM OrderDetail od
                INNER JOIN Product p ON od.ProductID = p.ProductID
                WHERE od.OrderID = @orderId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@orderId", orderId);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int productId = reader.GetInt32(reader.GetOrdinal("ProductID"));
                        string productCode = reader.GetString(reader.GetOrdinal("ProductCode"));
                        string productName = reader.GetString(reader.GetOrdinal("ProductName"));
                        int quantitySold = reader.GetInt32(reader.GetOrdinal("QuantitySolid"));

                        dvgOrderDetail.Rows.Add(productId, productCode, productName, quantitySold);
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading order details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OrderEdited?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection != null)
                {
                    connection.Open();

                    string updateOrderQuery = @"
                UPDATE Orders 
                SET OrderDate = @OrderDate, 
                    EmployeeID = @EmployeeID, 
                    CustomerID = @CustomerID
                WHERE OrderID = @OrderID";

                    SqlCommand updateOrderCommand = new SqlCommand(updateOrderQuery, connection);
                    updateOrderCommand.Parameters.AddWithValue("@OrderDate", dtpOrderDate.Value);
                    updateOrderCommand.Parameters.AddWithValue("@EmployeeID", employeeId);
                    updateOrderCommand.Parameters.AddWithValue("@CustomerID", cbxCustomer.SelectedValue);
                    updateOrderCommand.Parameters.AddWithValue("@OrderID", orderId);

                    updateOrderCommand.ExecuteNonQuery();

                    string deleteOrderDetailQuery = "DELETE FROM OrderDetail WHERE OrderID = @OrderID";
                    SqlCommand deleteOrderDetailCommand = new SqlCommand(deleteOrderDetailQuery, connection);
                    deleteOrderDetailCommand.Parameters.AddWithValue("@OrderID", orderId);
                    deleteOrderDetailCommand.ExecuteNonQuery();

                    foreach (DataGridViewRow row in dvgOrderDetail.Rows)
                    {
                        if (row.Cells["ProductID"].Value != null && row.Cells["QuantitySold"].Value != null)
                        {
                            int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                            int quantitySold = Convert.ToInt32(row.Cells["QuantitySold"].Value);

                            string insertOrderDetailQuery = @"
                        INSERT INTO OrderDetail (OrderID, ProductID, QuantitySolid) 
                        VALUES (@OrderID, @ProductID, @QuantitySolid)";

                            SqlCommand orderDetailCommand = new SqlCommand(insertOrderDetailQuery, connection);
                            orderDetailCommand.Parameters.AddWithValue("@OrderID", orderId);
                            orderDetailCommand.Parameters.AddWithValue("@ProductID", productId);
                            orderDetailCommand.Parameters.AddWithValue("@QuantitySolid", quantitySold);

                            orderDetailCommand.ExecuteNonQuery();
                        }
                    }

                    connection.Close();

                    MessageBox.Show("Order has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dvgOrderDetail.Rows.Clear();
                    ClearData();
                    OrderEdited?.Invoke(this, EventArgs.Empty);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProductQuantity(int productId, int adjustmentQuantity)
        {
            try
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection != null)
                {
                    connection.Open();

                    string query = @"
                UPDATE Product 
                SET InventoryQuantity = InventoryQuantity + @adjustmentQuantity 
                WHERE ProductID = @productId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@adjustmentQuantity", adjustmentQuantity);
                    command.Parameters.AddWithValue("@productId", productId);
                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the product quantity: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProductToOrder(int productId, string productCode, string productName, int quantitySold)
        {
            dvgOrderDetail.Rows.Add(productId, productCode, productName, quantitySold);
            LoadProducts();
            ClearData();
        }

        private void ClearData()
        {
            txtProductCode.Clear();
            txtProductName.Clear();
            txtProductQuantity.Clear();
            txtQuantitySolid.Clear();
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearchProduct.Text;
            SearchProduct(search);
        }

        private void SearchProduct(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                LoadProducts();
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
                    string sql = "SELECT p.ProductID, p.ProductCode, p.ProductName, " +
                                "p.InventoryQuantity " +
                                "FROM Product p " +
                                "WHERE p.ProductCode LIKE @search " +
                                "OR p.ProductName LIKE @search ";

                    // Initialize SqlDataAdapter to translate query result to a data table
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                    // Add params to query
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");

                    // Initialize data table
                    DataTable data = new DataTable();

                    // Fill datatable with data queried from database
                    adapter.Fill(data);

                    // Set the data source for data table
                    dgvProduct.DataSource = data;

                    // Close the connection
                    connection.Close();
                }
            }
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void InitializeOrderDetailGrid()
        {
            dvgOrderDetail.Columns.Clear();

            DataGridViewTextBoxColumn productIdColumn = new DataGridViewTextBoxColumn
            {
                Name = "ProductID",
                HeaderText = "ProductID",
                ReadOnly = true
            };
            dvgOrderDetail.Columns.Add(productIdColumn);

            DataGridViewTextBoxColumn productCodeColumn = new DataGridViewTextBoxColumn
            {
                Name = "ProductCode",
                HeaderText = "ProductCode",
                ReadOnly = true
            };
            dvgOrderDetail.Columns.Add(productCodeColumn);

            DataGridViewTextBoxColumn productNameColumn = new DataGridViewTextBoxColumn
            {
                Name = "ProductName",
                HeaderText = "ProductName",
                ReadOnly = true
            };
            dvgOrderDetail.Columns.Add(productNameColumn);

            DataGridViewTextBoxColumn quantitySoldColumn = new DataGridViewTextBoxColumn
            {
                Name = "QuantitySold",
                HeaderText = "QuantitySold",
                ReadOnly = true
            };
            dvgOrderDetail.Columns.Add(quantitySoldColumn);

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Action",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            dvgOrderDetail.Columns.Add(deleteButton);

            dvgOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dvgOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dvgOrderDetail.Columns[e.ColumnIndex].Name == "Delete")
            {
                int productId = Convert.ToInt32(dvgOrderDetail.Rows[e.RowIndex].Cells["ProductID"].Value);
                int quantitySold = Convert.ToInt32(dvgOrderDetail.Rows[e.RowIndex].Cells["QuantitySold"].Value);

                DialogResult confirm = MessageBox.Show("Do you want to remove this product from the order?",
                                                       "Confirm Delete",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    UpdateProductQuantity(productId, quantitySold);
                    dvgOrderDetail.Rows.RemoveAt(e.RowIndex);
                    LoadProducts();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtQuantitySolid.Text))
                {
                    MessageBox.Show("Please enter the quantity sold.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtQuantitySolid.Text, out int quantitySold))
                {
                    MessageBox.Show("Quantity sold must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtProductQuantity.Text, out int inventoryQuantity))
                {
                    MessageBox.Show("Product quantity is invalid. Please reload the product data.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (quantitySold > inventoryQuantity)
                {
                    MessageBox.Show("The quantity sold cannot be greater than the available inventory.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int updatedQuantity = inventoryQuantity - quantitySold;

                UpdateProductQuantity(productId, -quantitySold);

                txtProductQuantity.Text = updatedQuantity.ToString();

                AddProductToOrder(productId, txtProductCode.Text, txtProductName.Text, quantitySold);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvProduct.CurrentRow.Index;

            // Check if index is valid
            if (rowIndex >= 0 && rowIndex < dgvProduct.Rows.Count)
            {
                productId = Convert.ToInt32(dgvProduct.Rows[rowIndex].Cells[0].Value);

                // Get the ProductCode
                txtProductCode.Text = dgvProduct.Rows[rowIndex].Cells[1].Value.ToString();

                // Get the ProductName
                txtProductName.Text = dgvProduct.Rows[rowIndex].Cells[2].Value.ToString();

                // Get the ProductQuantity
                txtProductQuantity.Text = dgvProduct.Rows[rowIndex].Cells[3].Value.ToString();
            }
        }
    }
}
