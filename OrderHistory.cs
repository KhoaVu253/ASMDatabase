using Microsoft.Data.SqlClient;
using System.Data;

namespace Glocery_Shop
{
    public partial class OrderHistory : Form
    {
        private object authorityLevel;
        private object employeeId;
        private int orderId = 0;

        public OrderHistory(object authorityLevel)
        {
        }

        public OrderHistory(object authorityLevel, object employeeId)
        {
            InitializeComponent();

            this.authorityLevel = authorityLevel;
            this.employeeId = employeeId;
        }

        private void LoadOrderHistory()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "SELECT o.OrderID, o.OrderDate, " +
                              "e.EmployeeName, " +
                              "c.CustomerName " +
                              "FROM Orders o " +
                              "INNER JOIN Employee e ON o.EmployeeId = e.EmployeeId " +
                              "INNER JOIN Customer c ON o.CustomerId = c.CustomerId " +
                              "WHERE o.EmployeeId = @employeeId " +
                              "GROUP BY o.OrderID, o.OrderDate, e.EmployeeName, e.EmployeeCode, c.CustomerName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@employeeId", employeeId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dvgOrderHistory.DataSource = dataTable;
                orderId = Convert.ToInt32(dvgOrderHistory.Rows[0].Cells[0].Value.ToString());
            }
        }

        private void RedirectPage()
        {
            switch (this.authorityLevel)
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
                    ManageCustomer saleForm = new ManageCustomer(authorityLevel, employeeId);
                    this.Hide();
                    saleForm.Show();
                    break;
                default:
                    break;
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
            OrderHistory orderHistory = new OrderHistory(this.authorityLevel, this.employeeId);
            this.Hide();
            orderHistory.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addOrder = new AddOrder(Convert.ToInt32(employeeId));
            addOrder.OrderAdded += (s, args) =>
            {
                LoadOrderHistory();
            };
            addOrder.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var editOrder = new EditOrder(orderId);
            editOrder.OrderEdited += (s, args) =>
            {
                LoadOrderHistory();
            };
            editOrder.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (orderId > 0)
            {
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete this order? This action cannot be undone.",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection connection = DatabaseConnection.GetConnection();
                        if (connection != null)
                        {
                            connection.Open();

                            string deleteOrderDetailQuery = "DELETE FROM OrderDetail WHERE OrderID = @orderId";
                            SqlCommand deleteOrderDetailCommand = new SqlCommand(deleteOrderDetailQuery, connection);
                            deleteOrderDetailCommand.Parameters.AddWithValue("@orderId", orderId);
                            deleteOrderDetailCommand.ExecuteNonQuery();

                            string deleteOrderQuery = "DELETE FROM Orders WHERE OrderID = @orderId";
                            SqlCommand deleteOrderCommand = new SqlCommand(deleteOrderQuery, connection);
                            deleteOrderCommand.Parameters.AddWithValue("@orderId", orderId);
                            deleteOrderCommand.ExecuteNonQuery();

                            connection.Close();

                            MessageBox.Show("Order deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadOrderHistory();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an order to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dvgOrderHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                orderId = Convert.ToInt32(dvgOrderHistory.Rows[e.RowIndex].Cells[0].Value);
            }
        }
    }
}
