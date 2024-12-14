using Microsoft.Data.SqlClient;
using System.Data;
using System.Text;

namespace Glocery_Shop
{
    public partial class ManageEmployee : Form
    {
        // Variable to store selected employee from data gridview
        int employeeId;

        // Variable to store logged in user role in the system
        string authorityLevel;

        // Variable to store logged in user id in the system
        int userId;
        private string employeePosition;
        //private string authorityLevel;

        public ManageEmployee(string authorityLevel, int userId)
        {
            this.employeeId = 0;
            this.userId = userId;
            InitializeComponent();
            this.authorityLevel = authorityLevel;
        }

        private bool ValidateData(string employeeCode,
                              string employeeName,
                              string employeePosition,
                              string authorityLevel,
                              string username,
                              string password)
        {
            bool isValid = true;
            StringBuilder errorMessages = new StringBuilder();

            // Trim inputs to remove unnecessary spaces
            employeeCode = employeeCode?.Trim();
            employeeName = employeeName?.Trim();
            employeePosition = employeePosition?.Trim();
            authorityLevel = authorityLevel?.Trim();
            username = username?.Trim();
            password = password?.Trim();

            // Validate Employee Code
            if (string.IsNullOrEmpty(employeeCode))
            {
                errorMessages.AppendLine("- Employee Code cannot be blank.");
                isValid = false;
                if (txtEmployeeCode != null) txtEmployeeCode.Focus(); // Set focus on the first invalid field
            }

            // Validate Employee Name
            if (string.IsNullOrEmpty(employeeName))
            {
                errorMessages.AppendLine("- Employee Name cannot be blank.");
                isValid = false;
            }

            // Validate Employee Position
            if (string.IsNullOrEmpty(employeePosition))
            {
                errorMessages.AppendLine("- Employee Position cannot be blank.");
                isValid = false;
            }

            // Validate Authority Level
            if (string.IsNullOrEmpty(authorityLevel))
            {
                errorMessages.AppendLine("- Authority Level cannot be blank.");
                isValid = false;
            }

            // Validate Username
            if (string.IsNullOrEmpty(username))
            {
                errorMessages.AppendLine("- Username cannot be blank.");
                isValid = false;
            }

            // Validate Password
            if (string.IsNullOrEmpty(password))
            {
                errorMessages.AppendLine("- Password cannot be blank.");
                isValid = false;
            }

            // Display Error Messages
            if (!isValid)
            {
                MessageBox.Show(errorMessages.ToString(),
                                "Validation Errors",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

            return isValid;
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
        private void FlushEmployeeId()
        {
            // Flush employeeId value to check button and setup status for buttons
            this.employeeId = 0;
            ChangeButtonStatus(false);
        }
        private void LoadEmployeeData()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();

            if (connection != null)
            {
                connection.Open();
                string sql = "SELECT * FROM Employee";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvEmployee.DataSource = table;
                connection.Close();
            }
        }
        private void ClearData()
        {
            FlushEmployeeId();
            txtEmployeeCode.Text = string.Empty;
            txtEmployeeName.Text = string.Empty;
            txtEmployeePosition.Text = string.Empty;
            cbAuthorityLevel.SelectedIndex = 0;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmployeeCode.Focus();
        }
        public void InitializeCombobox()
        {
            // Setup for combobox
            cbAuthorityLevel.Items.Add("Admin");
            cbAuthorityLevel.Items.Add("Warehouse Manager");
            cbAuthorityLevel.Items.Add("Sale");

            // Set the selected index to the first item of the array (Admin)
            cbAuthorityLevel.SelectedIndex = 0;
        }

        private bool CheckUserExistence(int employeeId)
        {
            bool isExist = false;
            SqlConnection connection = DatabaseConnection.GetConnection();

            if (connection != null)
            {
                connection.Open();
                string checkCustomerQuery = "SELECT * FROM Employee WHERE EmployeeID = @employeeId";

                // Declare SqlCommand variable to add parameters to query and execute it
                SqlCommand command = new SqlCommand(checkCustomerQuery, connection);

                // Add parameters
                command.Parameters.AddWithValue("@employeeId", employeeId);

                // Declare SqlDataReader variable to read retrieved data
                SqlDataReader reader = command.ExecuteReader();

                // Check if reader has row (query success and return one row show user information)
                isExist = reader.HasRows;

                // Close the connection
                connection.Close();
            }

            return isExist;
        }

        private void AddUser(string employeeCode,
                     string employeeName,
                     string employeePosition,
                     string authorityLevel,
                     string username,
                     string password)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();

            if (connection != null)
            {
                connection.Open();
                string sql = "INSERT INTO Employee VALUES (@employeeCode, " +
                            "@employeeName, @employeePosition, " +
                            "@authorityLevel, @username, @password, 0)";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@employeeCode", employeeCode);
                command.Parameters.AddWithValue("@employeeName", employeeName);
                command.Parameters.AddWithValue("@employeePosition", employeePosition);
                command.Parameters.AddWithValue("@authorityLevel", authorityLevel);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Successfully add new user",
                                    "Information",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ClearData();
                    LoadEmployeeData();
                }
                else
                {
                    MessageBox.Show("Cannot add new user",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            connection.Close();
        }

        private void UpdateUser(int employeeId,
                     string employeeCode,
                     string employeeName,
                     string employeePosition,
                     string authorityLevel,
                     string username,
                     string password)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();

            if (connection != null)
            {
                connection.Open();
                string sql = "UPDATE Employee SET EmployeeCode = @employeeCode, " +
                            "EmployeeName = @employeeName, " +
                            "Position = @employeePosition, " +
                            "AuthorityLevel = @authorityLevel, " +
                            "Username = @username, " +
                            "Password = @password " +
                            "WHERE EmployeeID = @employeeId";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@employeeCode", employeeCode);
                command.Parameters.AddWithValue("@employeeName", employeeName);
                command.Parameters.AddWithValue("@employeePosition", employeePosition);
                command.Parameters.AddWithValue("@authorityLevel", authorityLevel);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@employeeId", employeeId);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Successfully update user",
                                    "Information",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ClearData();
                    LoadEmployeeData();
                }
                else
                {
                    MessageBox.Show("Cannot update user",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            connection.Close();
        }

        private void DeleteUser(int employeeId)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();

            if (connection != null)
            {
                connection.Open();
                string sql = "DELETE FROM Employee WHERE EmployeeID = @employeeId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@employeeId", employeeId);
                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Successfully delete user",
                                    "Information",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ClearData();
                    LoadEmployeeData();
                }
                else
                {
                    MessageBox.Show("Cannot delete user",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            connection.Close();
        }
        private void SearchUser(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                LoadEmployeeData();
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
                    string query = "SELECT * FROM Employee WHERE EmployeeCode LIKE @search " +
                                  "OR EmployeeName LIKE @search " +
                                  "OR Position LIKE @search " +
                                  "OR AuthorityLevel LIKE @search " +
                                  "OR Username LIKE @search " +
                                  "OR Password LIKE @search";

                    // Initialize SqlDataAdapter to translate query result to a data table
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");

                    // Initialize data table
                    DataTable table = new DataTable();

                    // Fill the data table by data queried from the database
                    adapter.Fill(table);

                    // Set the datasource of data gridview by the dataset
                    dgvEmployee.DataSource = table;

                    // Close the connection
                    connection.Close();
                }
            }
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
            ChangeButtonStatus(false);
            InitializeCombobox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get user input data
            string employeeCode = txtEmployeeCode.Text;
            string employeeName = txtEmployeeName.Text;
            string employeePosition = txtEmployeePosition.Text;
            string authorityLevel = cbAuthorityLevel.SelectedItem.ToString();
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validate data
            bool isValid = ValidateData(employeeCode,
                                       employeeName,
                                       employeePosition,
                                       authorityLevel,
                                       username,
                                       password);

            if (isValid)
            {
                AddUser(employeeCode, employeeName, employeePosition, authorityLevel, username, password);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get user input data
            string employeeCode = txtEmployeeCode.Text;
            string employeeName = txtEmployeeName.Text;
            string employeePosition = txtEmployeePosition.Text;
            string authorityLevel = cbAuthorityLevel.SelectedItem.ToString();
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validate data
            bool isValid = ValidateData(employeeCode,
                                       employeeName,
                                       employeePosition,
                                       authorityLevel,
                                       username,
                                       password);

            if (isValid)
            {
                UpdateUser(employeeId, employeeCode, employeeName, employeePosition, authorityLevel, username, password);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Ask for confirmation
            DialogResult result = MessageBox.Show("Do you want to delete this user?",
                                                   "Warning",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DeleteUser(employeeId);
            }
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
                    AdminForm adminForm = new AdminForm(authorityLevel, employeeId);
                    this.Hide();
                    adminForm.Show();
                    break;
                case "Warehouse Manager":
                    WarehouseManagerForm warehouseManagerForm = new WarehouseManagerForm(authorityLevel, employeeId);
                    this.Hide();
                    warehouseManagerForm.Show();
                    break;
                case "Sale":
                    SaleForm saleForm = new SaleForm(authorityLevel, employeeId);
                    this.Hide();
                    saleForm.Show();
                    break;
                default:
                    break;
            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get row index based on current cell clicked
            int rowIndex = dgvEmployee.CurrentCell.RowIndex;

            // Check if the value of each cell based on row index is used to load data from database (LoadEmployeeData function)
            // You have to check the sql query which is used to load data from database
            // I use this query and execute it in sql to imagine the datagridview
            // the column order in sql is ID, Name, Position, AuthorityLevel, Username, Password, PasswordChanged

            // Get the Employee Id from grid
            employeeId = Convert.ToInt32(dgvEmployee.Rows[rowIndex].Cells[0].Value);

            // Change the button status by true (update, delete, clear is enable when employeeId is assigned with value > 0)
            ChangeButtonStatus(true);

            // Get the text from each column and display it in the textbox
            txtEmployeeCode.Text = dgvEmployee.Rows[rowIndex].Cells[1].Value.ToString();
            txtEmployeeName.Text = dgvEmployee.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmployeePosition.Text = dgvEmployee.Rows[rowIndex].Cells[3].Value.ToString();

            // Get the authority level
            string authorityLevel = dgvEmployee.Rows[rowIndex].Cells[4].Value.ToString();

            // Change the combobox selected index based on the value of authority level
            if (authorityLevel == "Admin")
            {
                cbAuthorityLevel.SelectedIndex = 0;
            }
            else if (authorityLevel == "Warehouse Manager")
            {
                cbAuthorityLevel.SelectedIndex = 1;
            }
            else if (authorityLevel == "Sale")
            {
                cbAuthorityLevel.SelectedIndex = 2;
            }

            // Get the username
            txtUsername.Text = dgvEmployee.Rows[rowIndex].Cells[5].Value.ToString();
            txtPassword.Text = dgvEmployee.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearch.Text;
            SearchUser(search);
        }
        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            ManageEmployee manageEmployee = new ManageEmployee(this.authorityLevel, this.employeeId);
            this.Hide();
            manageEmployee.Show();
        }
    }
}

