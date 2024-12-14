using Microsoft.Data.SqlClient;
using System.Data;

namespace Glocery_Shop
{
    public partial class ManageCustomer : Form
    {
        private int customerId;
        private string authorityLevel;
        private int employeeId;
        private readonly int userId;

        public ManageCustomer(string authorityLevel, int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.authorityLevel = authorityLevel;
        }

        public ManageCustomer(object authorityLevel1, object employeeId1)
        {
        }

        private void ChangeButtonStatus(bool buttonStatus)
        {
            // When customer is selected, button add will be disabled
            // button Update, Delete & Clear will be enabled and vice versa
            btnUpdate.Enabled = buttonStatus;
            btnDelete.Enabled = buttonStatus;
            btnClear.Enabled = buttonStatus;
            btnAdd.Enabled = !buttonStatus;
        }
        private bool ValidateData(string customerCode, string customerName, string customerAddress, string phoneNumber)
        {
            // Validate user input data
            // Declare isValid variable to check. First we assume all data is valid and check each of it
            bool isValid = true;

            if (string.IsNullOrEmpty(customerCode))
            {
                MessageBox.Show("Customer Code cannot be blank.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                isValid = false;
                txtCustomerCode.Focus();
            }
            else if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Customer Name cannot be blank.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                isValid = false;
                txtCustomerName.Focus();
            }
            else if (string.IsNullOrEmpty(customerAddress))
            {
                MessageBox.Show("Customer Address cannot be blank.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                isValid = false;
                txtCustomerAddress.Focus();
            }
            else if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("PhoneNumber cannot be blank.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                isValid = false;
                txtPhonenumber.Focus();
            }

            return isValid;
        }
        private void FlushCustomerId()
        {
            // Flush customerId value to check button and setup status for buttons
            this.customerId = 0;
            ChangeButtonStatus(false);
        }
        private void LoadCustomerData()
        {
            // Open connection by call the GetConnection function in DatabaseConnection class
            SqlConnection connection = DatabaseConnection.GetConnection();

            // Check connection
            if (connection != null)
            {
                // Open the connection
                connection.Open();

                // Declare query to the database
                string query = "SELECT * FROM Customer";

                // Initialize SqlDataAdapter to translate query result to a data table
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Initialize data table
                DataTable table = new DataTable();

                // Fill the data table by data queried from the database
                adapter.Fill(table);

                // Set the datasource of data gridview by the dataset
                dvgCustomer.DataSource = table;

                // Close the connection
                connection.Close();
            }
        }
        private bool CheckUserExistence(int customerId)
        {
            bool isExist = false;
            SqlConnection connection = DatabaseConnection.GetConnection();

            if (connection != null)
            {
                connection.Open();
                string checkCustomerQuery = "SELECT * FROM Customer WHERE CustomerID = @customerId";

                // Declare SqlCommand variable to add parameters to query and execute it
                SqlCommand command = new SqlCommand(checkCustomerQuery, connection);

                // Add parameters
                command.Parameters.AddWithValue("@customerId", customerId);

                // Declare SqlDataReader variable to read retrieved data
                SqlDataReader reader = command.ExecuteReader();

                // Check if reader has row (query success and return one row show user information)
                isExist = reader.HasRows;

                connection.Close();
            }

            return isExist;
        }
        private void AddCustomer(string customerCode, string customerName, string customerAddress, string phoneNumber)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();

            if (connection != null)
            {
                connection.Open();
                string query = "INSERT INTO Customer (CustomerCode, CustomerName, PhoneNumber, Address) VALUES (@customerCode, @customerName, @phoneNumber, @customerAddress)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@customerCode", customerCode);
                command.Parameters.AddWithValue("@customerName", customerName);
                command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@customerAddress", customerAddress);
                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Successfully add new customer.",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occur while adding customer.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                connection.Close();

                // Clear all user input data and flush customerID
                ClearData();
                LoadCustomerData();
            }

        }
        private void UpdateCustomer(int customerId, string customerCode, string customerName, string customerAddress, string phoneNumber)
        {
            // Initialize database connection by call GetConnection function from DatabaseConnection class
            SqlConnection connection = DatabaseConnection.GetConnection();

            if (connection != null)
            {
                connection.Open();
                string query = "UPDATE Customer SET " +
                               "CustomerCode = @customerCode, " +
                               "CustomerName = @customerName, " +
                               "Address = @customerAddress, " +
                               "PhoneNumber = @phoneNumber " +
                               "WHERE CustomerID = @customerId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@customerCode", customerCode);
                command.Parameters.AddWithValue("@customerName", customerName);
                command.Parameters.AddWithValue("@customerAddress", customerAddress);
                command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@customerId", customerId);
                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Successfully update customer.",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occur while updating customer.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                connection.Close();

                // Clear all user input data and flush customerID
                ClearData();
                LoadCustomerData();
            }
        }
        private void DeleteCustomer(int customerId)
        {
            // Initialize database connection by call GetConnection function from DatabaseConnection class
            SqlConnection connection = DatabaseConnection.GetConnection();

            if (connection != null)
            {
                connection.Open();

                // Delete order detail records where orderId = customerId
                string deleteOrderDetailQuery = "DELETE FROM OrderDetail WHERE OrderId = @customerId";
                SqlCommand command = new SqlCommand(deleteOrderDetailQuery, connection);
                command.Parameters.AddWithValue("@customerId", customerId);
                command.ExecuteNonQuery();

                // Delete orders where customerId = customerId
                string deleteOrdersQuery = "DELETE FROM Orders WHERE CustomerId = @customerId";
                command = new SqlCommand(deleteOrdersQuery, connection);
                command.Parameters.AddWithValue("@customerId", customerId);
                command.ExecuteNonQuery();

                // Delete customer record. (we can delete a customer record because it is not refered by other records in order table)
                string deleteCustomerQuery = "DELETE FROM Customer WHERE CustomerId = @customerId";
                command = new SqlCommand(deleteCustomerQuery, connection);
                command.Parameters.AddWithValue("@customerId", customerId);
                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Successfully delete customer.",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occur while deleting customer.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                connection.Close();

                // Clear all user input data and flush customerID
                ClearData();
                LoadCustomerData();
            }
        }
        private void SearchCustomer(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                LoadCustomerData();
            }
            else
            {
                // Open connection by call the GetConnection function in DatabaseConnection class
                SqlConnection connection = DatabaseConnection.GetConnection();

                if (connection != null)
                {
                    connection.Open();

                    // Declare query to the database
                    string query = "SELECT * FROM Customer WHERE CustomerCode LIKE '%" + search + "%' OR CustomerName LIKE '%" + search + "%' OR PhoneNumber LIKE '%" + search + "%' OR Address LIKE '%" + search + "%'";

                    // Initialize SqlDataAdapter to translate query result to a data table
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // Initialize data table and set parameter
                    DataTable table = new DataTable();
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");

                    // Fill the data table by data queried from the database
                    adapter.Fill(table);

                    // Set the datasource of data gridview by the dataset
                    dvgCustomer.DataSource = table;

                    // Close the connection
                    connection.Close();
                }
            }

        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            // Load data from database to the data gridview
            LoadCustomerData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get data from user input
            string customerCode = txtCustomerCode.Text;
            string customerName = txtCustomerName.Text;
            string customerAddress = txtCustomerAddress.Text;
            string phoneNumber = txtPhonenumber.Text;

            // Validate data
            bool isValid = ValidateData(customerCode, customerName, customerAddress, phoneNumber);

            if (isValid)
            {
                AddCustomer(customerCode, customerName, customerAddress, phoneNumber);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check customerId
            if (customerId > 0)
            {
                // Check user exist
                bool isUserExist = CheckExistence(customerId);

                if (isUserExist)
                {
                    // Get data from user input
                    string customerCode = txtCustomerCode.Text;
                    string customerName = txtCustomerName.Text;
                    string customerAddress = txtCustomerAddress.Text;
                    string phoneNumber = txtPhonenumber.Text;

                    // Validate data
                    bool isValid = ValidateData(customerCode, customerName, customerAddress, phoneNumber);

                    if (isValid)
                    {
                        UpdateCustomer(customerId, customerCode, customerName, customerAddress, phoneNumber);
                    }
                }
                else
                {
                    MessageBox.Show("No customer found.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private bool CheckExistence(int customerId)
        {
            const string query = "SELECT COUNT(1) FROM Customer WHERE CustomerId = @customerId";

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                if (connection != null)
                {
                    try
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@customerId", customerId);

                            int count = Convert.ToInt32(command.ExecuteScalar());
                            return count > 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check customerId
            if (customerId > 0)
            {
                // Ask user for confirmation
                DialogResult result = MessageBox.Show(
                    "Do you want to delete this customer with all related data?",
                    "Warning",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    // Check if user exist
                    bool isUserExist = CheckExistence(customerId);
                    if (isUserExist)
                    {
                        DeleteCustomer(customerId);
                    }
                    else
                    {
                        MessageBox.Show(
                            "No customer found.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            txtCustomerCode.Clear();
            txtCustomerName.Clear();
            txtCustomerAddress.Clear();
            txtPhonenumber.Clear();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = btnDelete.Enabled = btnClear.Enabled = false;
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

        private void dvgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dvgCustomer.CurrentCell.RowIndex;
            if (index > -1)
            {
                customerId = (int)dvgCustomer.Rows[index].Cells[0].Value;
                txtCustomerCode.Text = dvgCustomer.Rows[index].Cells[1].Value.ToString();
                txtCustomerName.Text = dvgCustomer.Rows[index].Cells[2].Value.ToString();
                txtPhonenumber.Text = dvgCustomer.Rows[index].Cells[3].Value.ToString();
                txtCustomerAddress.Text = dvgCustomer.Rows[index].Cells[4].Value.ToString();
                ChangeButtonStatus(true);
            }
        }

        private void dvgCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dvgCustomer.CurrentCell.RowIndex;
            if (index > -1)
            {
                customerId = (int)dvgCustomer.Rows[index].Cells[0].Value;
                string customerName = dvgCustomer.Rows[index].Cells[2].Value.ToString();
                Order order = new Order(customerId, employeeId, customerName);
                order.ShowDialog();
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearch.Text;
            SearchCustomer(search);
        }
        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            ManageCustomer manageCustomer = new ManageCustomer(authorityLevel, employeeId);
            this.Hide();
            manageCustomer.Show();
        }
    }
}
