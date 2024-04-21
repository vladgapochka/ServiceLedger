using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceLedger
{
    class DatabaseHelper
    {
        public static string GetConnectionString()
        {
            return "server=localhost;port=3306;user=root;password=;database=ServiceSalesDB";
        }

        public static DataTable GetAllClients()
        {
            using (var connection = new MySqlConnection(GetConnectionString()))
            {
                const string query = "SELECT * FROM Clients";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable clientsTable = new DataTable();
                        adapter.Fill(clientsTable);
                        return clientsTable;
                    }
                }
            }
        }

        public static DataTable GetAllProducts()
        {
            using (var connection = new MySqlConnection(GetConnectionString()))
            {
                const string query = "SELECT * FROM Products";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable productsTable = new DataTable();
                        adapter.Fill(productsTable);
                        return productsTable;
                    }
                }
            }
        }
        public static bool AddNewClient(string name, string phone, string email)
        {
            try
            {
                using (var connection = new MySqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    string query = "INSERT INTO Clients (Name, Phone, Email) VALUES (@Name, @Phone, @Email)";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Email", email);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool AddNewProducts(string productName, string costPerUnit)
        {
            try
            {
                using (var connection = new MySqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    string query = "INSERT INTO Products ( ProductName, CostPerUnit) VALUES (@ProductName, @CostPerUnit)";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@CostPerUnit", costPerUnit);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool UpdateClient(string clientId, string name, string phone, string email)
        {
            try
            {
                using (var connection = new MySqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    string query = "UPDATE Clients SET Name = @Name, Phone = @Phone, Email = @Email WHERE ClientID = @ClientID";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClientID", clientId);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Email", email);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool UpdateProduct(string productId, string productName, string costPerUnit)
        {
            try
            {
                using (var connection = new MySqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    string query = "UPDATE Products SET ProductName = @ProductName, CostPerUnit = @CostPerUnit WHERE ProductID = @ProductID";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", productId);
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@CostPerUnit", costPerUnit);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool DeleteClient(string clientId)
        {
            try
            {
                using (var connection = new MySqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    string query = "DELETE FROM Clients WHERE ClientID = @ClientID";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClientID", clientId);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool DeleteProduct(string productId)
        {
            try
            {
                using (var connection = new MySqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    string query = "DELETE FROM Products WHERE ProductID = @ProductID";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", productId);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static decimal GetProductPrice(int productId)
{
    decimal price = 0;

    string connectionString = "server=localhost;port=3306;user=root;password=;database=ServiceSalesDB";

    using (var connection = new MySqlConnection(connectionString))
    {
        try
        {
            connection.Open();

            string query = "SELECT CostPerUnit FROM Products WHERE ProductID = @ProductID";

            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductID", productId);
                var result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    price = Convert.ToDecimal(result);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка подключения к базе данных: " + ex.Message);
        }
    }

    return price;
}

        public static bool AddNewSale(int clientId, DateTime saleDate, DataTable products)
        {
            var success = true;

            string connectionString = GetConnectionString();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string insertSaleQuery = "INSERT INTO Sales (ClientID, SaleDateTime) VALUES (@ClientID, @SaleDateTime); SELECT LAST_INSERT_ID();";
                        int saleId;
                        using (var command = new MySqlCommand(insertSaleQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@ClientID", clientId);
                            command.Parameters.AddWithValue("@SaleDateTime", saleDate);
                            saleId = Convert.ToInt32(command.ExecuteScalar());
                        }

                        string insertSaleDetailQuery = "INSERT INTO SaleDetails (SaleID, ProductID, Quantity, TotalCost) VALUES (@SaleID, @ProductID, @Quantity, @TotalCost);";
                        foreach (DataRow row in products.Rows)
                        {
                            using (var command = new MySqlCommand(insertSaleDetailQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@SaleID", saleId);
                                command.Parameters.AddWithValue("@ProductID", row["ProductID"]);
                                command.Parameters.AddWithValue("@Quantity", row["Quantity"]);
                                command.Parameters.AddWithValue("@TotalCost", row["TotalCost"]);
                                command.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            transaction.Rollback();
                        }
                        catch
                        {
                        }
                        Console.WriteLine("Ошибка при добавлении продажи: " + ex.Message);
                        success = false;
                    }
                }
            }

            return success;
        }
        public static DataTable GetSalesData(DateTime startDate, DateTime endDate)
        {
            using (var connection = new MySqlConnection(GetConnectionString()))
            {
                const string query = @"
            SELECT 
                c.Name AS ClientName, 
                p.ProductName, 
                sd.Quantity, 
                sd.TotalCost, 
                s.SaleDateTime
            FROM SaleDetails sd
            JOIN Sales s ON sd.SaleID = s.SaleID
            JOIN Clients c ON s.ClientID = c.ClientID
            JOIN Products p ON sd.ProductID = p.ProductID
            WHERE s.SaleDateTime BETWEEN @StartDate AND @EndDate";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable salesData = new DataTable();
                        adapter.Fill(salesData);
                        return salesData;
                    }
                }
            }
        }

        public static DataTable GetClientSalesReport(int clientId, DateTime startDate, DateTime endDate)
        {
            using (var connection = new MySqlConnection(GetConnectionString()))
            {
                const string query = @"
            SELECT 
                c.Name AS ClientName, 
                p.ProductName, 
                sd.Quantity, 
                sd.TotalCost, 
                s.SaleDateTime
            FROM SaleDetails sd
            JOIN Sales s ON sd.SaleID = s.SaleID
            JOIN Clients c ON s.ClientID = c.ClientID
            JOIN Products p ON sd.ProductID = p.ProductID
            WHERE c.ClientID = @ClientID AND s.SaleDateTime BETWEEN @StartDate AND @EndDate
            ORDER BY s.SaleDateTime, p.ProductName";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientID", clientId);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable reportData = new DataTable();
                        adapter.Fill(reportData);
                        return reportData;
                    }
                }
            }
        }







    }
}
