using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glocery_Shop
{
    public class DatabaseConnection
    {
        private static string _connectionString = "Data Source=DESKTOP-ACRBMJK\\SQLEXPRESS;" +
                                                  "Initial Catalog=ASM_SE07203;" +
                                                  "Integrated Security=True;" +
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
                MessageBox.Show("Error while connecting to the database",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            return connection;
        }
    }
}