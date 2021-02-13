using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SmallStoreManagement
{
    public class Product
    {
        private static readonly string cs = @"URI = file:SmallStoreManagement.db";

        public string ProductName { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int Id { get; set; }

        public static List<Product> GetAllProducts()
        {
            List<Product> result = new List<Product>();
            string stm = "SELECT Id, ProductName, Category, Price FROM Products";
            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(stm, con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new Product()
                            {
                                Id = reader.GetInt32(0),
                                ProductName = reader.GetString(1),
                                Category = reader.GetString(2),
                                Price = reader.GetInt32(3)
                            });
                        }
                    }
                }
                con.Close();
            }
            return result;
        }
        public static void AddProduct(Product p)
        {

            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                string stm = "INSERT INTO Products (ProductName, Category, Price) VALUES (@ProductName, @Category, @Price);";
                SQLiteCommand cmd = new SQLiteCommand(stm, con);

                cmd.Parameters.AddWithValue("@ProductName", p.ProductName);
                cmd.Parameters.AddWithValue("@Category", p.Category);
                cmd.Parameters.AddWithValue("@Price", p.Price);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }

    }
}