using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using System.Net.Http;
using Newtonsoft.Json;

namespace FreshGuardApp.Helper
{
    internal class DatabaseHelper
    {
        // Bağlantı dizesi (AWS RDS bağlantı bilgileri)
        private readonly string connectionString = "Server=database-1.c58s00oc6nv8.eu-central-1.rds.amazonaws.com;Database=my_database;User ID=admin;Password=cbuteam2024.RM;Port=3306;";

        // Veritabanına bağlanmak için metod
        public MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open(); // Bağlantıyı aç
                Console.WriteLine("Veritabanı bağlantısı başarılı.");
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Veritabanı bağlantısı başarısız: " + ex.Message);
                return null;
            }
        }

        private string GenerateRandomPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public int RegisterUser(string username, string password, string email)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "INSERT INTO Users (Username, MainPassword, Email) VALUES (@Username, @Password, @Email)";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Email", email);

                        connection.Open();
                        command.ExecuteNonQuery();

                        int newUserId = (int)command.LastInsertedId;

                        string storeManagerPassword = GenerateRandomPassword();

                        // 4. Adım: Store Manager'ı StoreManagers tablosuna ekle
                        string storeManagerQuery = "INSERT INTO StoreManagers (UserID,  StoreManPass) VALUES (@newUserId, @Pass)";
                        MySqlCommand storeManagerCommand = new MySqlCommand(storeManagerQuery, connection);
                        storeManagerCommand.Parameters.AddWithValue("@newUserId", newUserId);
                        storeManagerCommand.Parameters.AddWithValue("@Pass", storeManagerPassword);
                        storeManagerCommand.ExecuteNonQuery();

                        Console.WriteLine($"Kullanıcı başarıyla kaydedildi. UserID: {newUserId}");

                        
                        MessageBox.Show(
                            $"Registration successful!\n\nYour Store Manager Account:\n" +
                            $"Store Manager ID: {newUserId}\nPassword: {storeManagerPassword}",
                            "Registration Completed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        return newUserId;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Kayıt işlemi sırasında hata: " + ex.Message);
                        return -1;
                    }
                    
                }

                return -1;
            }
        }

        public int LoginUser(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to check if username and password match
                    string query = "SELECT UserID FROM Users WHERE Username = @Username AND MainPassword = @Password";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password); // Password stored as plain text

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        // Login successful, return UserID
                        int userID = Convert.ToInt32(result);
                        Console.WriteLine($"Login successful. UserID: {userID}");
                        return userID;
                    }
                    else
                    {
                        // Login failed
                        Console.WriteLine("Login failed: Invalid username or password.");
                        return -1; // Indicate failure
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error during login: " + ex.Message);
                    return -2; // Indicate error
                }
            }
        }

        public bool StoreManInsideLog(string username, string password, out DataRow userData)
        {
            userData = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM StoreManagers WHERE UserID = @Username AND StoreManPass = @Password ";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        userData = dataTable.Rows[0];
                        return true; // Giriş başarılı
                    }
                    else
                    {
                        return false; // Giriş başarısız
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                    return false;
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        // Inventory Manager için giriş fonksiyonu
        public bool InventoryManInsideLog(string username, string password, out DataRow userData)
        {
            userData = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM InventoryManagers WHERE ManagerID = @ManID AND InventoryManPass = @Password";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ManID", username);
                    command.Parameters.AddWithValue("@Password", password);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        userData = dataTable.Rows[0];
                        return true; // Giriş başarılı
                    }
                    else
                    {
                        return false; // Giriş başarısız
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                    return false;
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        public DataTable GetCategories(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT CategoryID, CategoryName, CreatedAt FROM Categories WHERE UserID = @UserID ORDER BY CreatedAt DESC";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                    return null;
                }
            }
        }

        public bool AddCategory(int userId, string categoryName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Categories (UserID, CategoryName) VALUES (@UserID, @CategoryName)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.Parameters.AddWithValue("@CategoryName", categoryName);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                    return false;
                }
            }
        }

        public bool UpdateCategory(int userId, int categoryId, string newCategoryName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Categories SET CategoryName = @CategoryName WHERE CategoryID = @CategoryID AND UserID = @UserID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CategoryName", newCategoryName);
                    command.Parameters.AddWithValue("@CategoryID", categoryId);
                    command.Parameters.AddWithValue("@UserID", userId);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                    return false;
                }
            }
        }

        public bool DeleteCategory(int userId, int categoryId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Categories WHERE CategoryID = @CategoryID AND UserID = @UserID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CategoryID", categoryId);
                    command.Parameters.AddWithValue("@UserID", userId);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                    return false;
                }
            }
        }

        public bool AddProductWithBarcode(int userId, string productName, string productCategory, int quantity, byte[] image, DateTime expirationDate)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    /*Guid guid = Guid.NewGuid();
                    string barcode = $"PRD{guid.ToString().Substring(0, 8).ToUpper()}";*/

                    Random random = new Random();
                    int barcodeA = random.Next(100000, 1000000);
                    string barcode = "PRD" + barcodeA;

                    // Insert product with the generated barcode
                    string query = "INSERT INTO Products (UserID, ProductName, ProductCategory, Quantity, Image, Barcode, ExpirationDate) " +
                                   "VALUES (@UserID, @ProductName, @ProductCategory, @Quantity, @Image, @Barcode, @Exp)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@ProductCategory", productCategory);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Image", image != null ? image : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Barcode", barcode);
                    command.Parameters.AddWithValue("@EXP", expirationDate);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable GetProducts(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ProductID, ProductName, ProductCategory, Quantity, Barcode, Image, CreatedAt, DATE_FORMAT(ExpirationDate, '%Y-%m-%d') AS ExpirationDate " +
                                   "FROM Products WHERE UserID = @UserID ORDER BY CreatedAt DESC";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public DateTime GetProductExpirationDate(int userId, int productId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ExpirationDate FROM Products WHERE UserID = @UserID AND ProductID = @ProductID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.Parameters.AddWithValue("@ProductID", productId);

                    // Use ExecuteScalar to retrieve a single value
                    object result = command.ExecuteScalar();

                    // Check if result is not null and convert to DateTime
                    if (result != null && DateTime.TryParse(result.ToString(), out DateTime expirationDate))
                    {
                        return expirationDate;
                    }
                    else
                    {
                        // Return a default date or handle null case
                        Console.WriteLine("Expiration date not found.");
                        return DateTime.MinValue; // Or any default date
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return DateTime.MinValue; // Return a default date in case of an error
                }
            }
        }


        public bool UpdateProductWithImage(int productId, string productName, string productCategory, int quantity, DateTime expirationDate) //, byte[] image
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Products SET ProductName = @ProductName, ProductCategory = @ProductCategory, " +
                                   "Quantity = @Quantity, ExpirationDate = @Exp WHERE ProductID = @ProductID";  //, Image = @Image
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@ProductCategory", productCategory);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    //command.Parameters.AddWithValue("@Image", image != null ? image : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ProductID", productId);
                    command.Parameters.AddWithValue("@Exp", expirationDate);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool DeleteProduct(int productId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Products WHERE ProductID = @ProductID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductID", productId);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable GetUserCategories(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT  CategoryName FROM Categories WHERE UserID = @UserID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public List<string> GetProduct(int userId, int prodID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    List<string> productList = new List<string>();
                    connection.Open();

                    string query = "SELECT ProductName, ProductCategory, Quantity, ExpirationDate " +
                                   "FROM Products WHERE UserID = @UserID AND ProductID = @prodID ORDER BY CreatedAt DESC";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.Parameters.AddWithValue("@prodID", prodID);

                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    // Check if the DataTable contains any rows
                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow row = dataTable.Rows[0];
                        productList.Add(row["ProductName"].ToString());   // Add ProductName
                        productList.Add(row["ProductCategory"].ToString()); // Add ProductCategory
                        productList.Add(row["Quantity"].ToString());      // Add Quantity
                        productList.Add(Convert.ToDateTime(row["ExpirationDate"]).ToString("yyyy-MM-dd"));
                    }

                    return productList.Count > 0 ? productList : null; // Return null if no products found
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null; // Return null in case of error
                }
            }
        }

        public DataTable GetInventoryManagers()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ManagerID, UserID, InventoryManPass FROM InventoryManagers";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public bool AddInventoryManager(int userId, string password, int ManID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO InventoryManagers (ManagerID, UserID, InventoryManPass) VALUES (@ManId, @UserID, @Password)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ManId", ManID);
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.Parameters.AddWithValue("@Password", password);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public void UpdateInventoryManager(int oldID ,int managerId, int userId, string password)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE InventoryManagers SET InventoryManPass = @Password, ManagerID = @ManagerId WHERE ManagerID = @old AND UserID = @UserId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@ManagerId", managerId);
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.Parameters.AddWithValue("@old", oldID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            System.Windows.Forms.MessageBox.Show("Update successful.");
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Update failed. No matching record found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
        }


        public void DeleteInventoryManager(int managerId, int userId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM InventoryManagers WHERE ManagerID = @ManagerId AND UserID = @UserId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ManagerId", managerId);
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            System.Windows.Forms.MessageBox.Show("Delete successful.");
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Delete failed. No matching record found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
        }

        public DataTable GetSuppliersByUser(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT SupplierID, SupplierName, ContactInfo, Address, CreatedAt " +
                                   "FROM Suppliers WHERE UserID = @UserID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public bool AddSupplier(int userId, string supplierName, string contactInfo, string address)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Suppliers (UserID, SupplierName, ContactInfo, Address) " +
                                   "VALUES (@UserID, @SupplierName, @ContactInfo, @Address)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.Parameters.AddWithValue("@SupplierName", supplierName);
                    command.Parameters.AddWithValue("@ContactInfo", contactInfo);
                    command.Parameters.AddWithValue("@Address", address);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool UpdateSupplier(int supplierId, int userId, string supplierName, string contactInfo, string address)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Suppliers SET SupplierName = @SupplierName, ContactInfo = @ContactInfo, " +
                                   "Address = @Address WHERE SupplierID = @SupplierID AND UserID = @UserID";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SupplierID", supplierId);
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.Parameters.AddWithValue("@SupplierName", supplierName);
                    command.Parameters.AddWithValue("@ContactInfo", contactInfo);
                    command.Parameters.AddWithValue("@Address", address);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool DeleteSupplier(int supplierId, int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Suppliers WHERE SupplierID = @SupplierID AND UserID = @UserID";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SupplierID", supplierId);
                    command.Parameters.AddWithValue("@UserID", userId);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable GetPurchasesByUser(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT PurchaseID, ProductName, Quantity, Price, SupplierName FROM Purchases WHERE UserID = @UserID";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public bool AddPurchase(int userId, string supplierName, string productName, int quantity, decimal price)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Purchases (UserID, SupplierName, ProductName, Quantity, Price) VALUES (@UserID, @SupplierName, @ProductName, @Quantity, @Price)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.Parameters.AddWithValue("@SupplierName", supplierName);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Price", price);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool UpdatePurchase(int purchaseId, string supplierName, string productName, int quantity, decimal price)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Purchases SET SupplierName = @SupplierName, ProductName = @ProductName, Quantity = @Quantity, Price = @Price WHERE PurchaseID = @PurchaseID";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PurchaseID", purchaseId);
                    command.Parameters.AddWithValue("@SupplierName", supplierName);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Price", price);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool DeletePurchase(int purchaseId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Purchases WHERE PurchaseID = @PurchaseID";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PurchaseID", purchaseId);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable GetUserSuppliers(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT SupplierName FROM Suppliers WHERE UserID = @UserID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public bool DeleteProductbyName(int productId, string name)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Products WHERE ProductID = @ProductID AND ProductName = @prodName";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductID", productId);
                    command.Parameters.AddWithValue("@prodName", name);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public int GetProdIDFromProdName(int userID, string a)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ProductID FROM Products WHERE ProductName = @prodName AND UserID = @UserID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@prodName", a);
                    command.Parameters.AddWithValue("@UserID", userID);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result); // Dönen değeri int'e çeviriyoruz.
                    }
                    else
                    {
                        return -1; // Veri bulunamadığında -1 döndürüyoruz.
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return -2;
                }
            }
        }

        public DataTable GetSalesByUser(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT SaleID, ProductName, Quantity, SalePrice, TotalPrice, CreatedAt
                             FROM Sales
                             WHERE UserID = @UserID";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public bool AddSale(int userId, string productName, int quantity, decimal salePrice)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"INSERT INTO Sales (UserID, ProductName, Quantity, SalePrice)
                             VALUES (@UserID, @ProductName, @Quantity, @SalePrice)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@SalePrice", salePrice);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        /*public bool UpdateSale(int saleId, string productName, int quantity, decimal salePrice, Guna2ComboBox a)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    if (!a.Text.Equals(productName))
                    {
                        connection.Open();
                        string query = @"UPDATE Sales
                             SET ProductName = @ProductName, Quantity = @Quantity, SalePrice = @SalePrice
                             WHERE SaleID = @SaleID";


                    }
                    connection.Open();
                    string query = @"UPDATE Sales
                             SET ProductName = @ProductName, Quantity = @Quantity, SalePrice = @SalePrice
                             WHERE SaleID = @SaleID";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SaleID", saleId);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@SalePrice", salePrice);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }*/

        public bool UpdateSaleWithProductAdjustment(int saleId, string oldProductName, string newProductName, int oldQuantity, int newQuantity, decimal salePrice, int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // 1. Eski ürünü iade et (stoku artır)
                        string increaseOldProductStockQuery = @"UPDATE Products 
                                                        SET Quantity = Quantity + @OldQuantity 
                                                        WHERE ProductName = @OldProductName AND UserID = @UserID";
                        MySqlCommand increaseCommand = new MySqlCommand(increaseOldProductStockQuery, connection, transaction);
                        increaseCommand.Parameters.AddWithValue("@OldProductName", oldProductName);
                        increaseCommand.Parameters.AddWithValue("@OldQuantity", oldQuantity);
                        increaseCommand.Parameters.AddWithValue("@UserID", userId);
                        increaseCommand.ExecuteNonQuery();

                        // 2. Yeni ürünün stoklarını azalt
                        string decreaseNewProductStockQuery = @"UPDATE Products 
                                                        SET Quantity = Quantity - @NewQuantity 
                                                        WHERE ProductName = @NewProductName AND UserID = @UserID";
                        MySqlCommand decreaseCommand = new MySqlCommand(decreaseNewProductStockQuery, connection, transaction);
                        decreaseCommand.Parameters.AddWithValue("@NewProductName", newProductName);
                        decreaseCommand.Parameters.AddWithValue("@NewQuantity", newQuantity);
                        decreaseCommand.Parameters.AddWithValue("@UserID", userId);
                        decreaseCommand.ExecuteNonQuery();

                        // 3. Satışı güncelle
                        string updateSaleQuery = @"UPDATE Sales
                                           SET ProductName = @NewProductName, Quantity = @NewQuantity, SalePrice = @SalePrice
                                           WHERE SaleID = @SaleID AND UserID = @UserID";
                        MySqlCommand updateCommand = new MySqlCommand(updateSaleQuery, connection, transaction);
                        updateCommand.Parameters.AddWithValue("@NewProductName", newProductName);
                        updateCommand.Parameters.AddWithValue("@NewQuantity", newQuantity);
                        updateCommand.Parameters.AddWithValue("@SalePrice", salePrice);
                        updateCommand.Parameters.AddWithValue("@SaleID", saleId);
                        updateCommand.Parameters.AddWithValue("@UserID", userId);
                        updateCommand.ExecuteNonQuery();

                        // Transaction'u tamamla
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }


        public bool DeleteSale(int saleId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"DELETE FROM Sales WHERE SaleID = @SaleID";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SaleID", saleId);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable GetUserProducts(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ProductName FROM Products WHERE UserID = @UserID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public bool DecreaseQuantityOfProduct(int userId, int numberQ, string prodName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    int prodID = GetProdIDFromProdName(userId,prodName);
                    connection.Open();
                    int firstQuan = GetProdQuantity(userId, prodID); 
                    string query = "UPDATE Products SET Quantity = @Quantity WHERE UserID = @UserID AND ProductID = @ProdID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.Parameters.AddWithValue("@ProdID", prodID);
                    command.Parameters.AddWithValue("@Quantity", firstQuan-numberQ);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool IncreaseQuantityOfProduct(int userId, int numberQ, string prodName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    int prodID = GetProdIDFromProdName(userId, prodName);
                    connection.Open();
                    int firstQuan = GetProdQuantity(userId, prodID);
                    string query = "UPDATE Products SET Quantity = @Quantity WHERE UserID = @UserID AND ProductID = @ProdID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.Parameters.AddWithValue("@ProdID", prodID);
                    command.Parameters.AddWithValue("@Quantity", firstQuan + numberQ);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public int GetProdQuantity(int userID, int prodID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Quantity FROM Products WHERE ProductID = @prodId AND UserID = @UserID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@prodId", prodID);
                    command.Parameters.AddWithValue("@UserID", userID);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result); // Dönen değeri int'e çeviriyoruz.
                    }
                    else
                    {
                        return -1; // Veri bulunamadığında -1 döndürüyoruz.
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return -2;
                }
            }
        }

        public bool RegisterCharity(string charityName, string email, string charityUsername, string password, string contactInfo, string address, string city)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"INSERT INTO CharityOrganizations 
                             (CharityName, Email, CharityUsername, Password, ContactInfo, Address, City)
                             VALUES (@CharityName, @Email, @CharityUsername, @Password, @ContactInfo, @Address, @City)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CharityName", charityName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@CharityUsername", charityUsername);
                    command.Parameters.AddWithValue("@Password", password); // Şifre düz saklanır
                    command.Parameters.AddWithValue("@ContactInfo", contactInfo);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@City", city);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool LoginCharity(string charityUsername, string password, out int charityId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT CharityID FROM CharityOrganizations WHERE CharityUsername = @CharityUsername AND Password =@Password";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CharityUsername", charityUsername);
                    command.Parameters.AddWithValue("@Password", password);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Veritabanından Password ve CharityID alınır
                            
                            charityId = Convert.ToInt32(reader["CharityID"]);

                            // Şifre kontrolü
                            return charityId > 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            charityId = -1;
            return false;
        }

        public async Task GetRecommendations(int userId)
        {
            var httpClient = new HttpClient();
            var data = new
            {
                user_id = userId
            };
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("http://localhost:5000/get_recommendations", content);
            var result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result);
        }

        // Bağlantıyı test etmek için metod
        /*public bool TestConnection()
        {
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Bağlantı başarılı!");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bağlantı hatası: " + ex.Message);
                    return false;
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                        Console.WriteLine("Bağlantı kapatıldı.");
                    }
                }
            }
        }*/
    }
}

