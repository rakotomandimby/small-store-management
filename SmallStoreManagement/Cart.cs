using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SmallStoreManagement
{
    class Cart
    {
        public int ownerId { get; set; }
        public string ownerName { get; set; }
        public int total { get; set; }
        // public List<CartItem> content { get; set; }
        private static readonly string cs = @"URI = file:SmallStoreManagement.db";

        public static List<Cart> GetAllCarts() 
        {
            List<Cart> result = new List<Cart>();
            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                string stm = "SELECT Owner FROM Carts GROUP BY Owner";
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(stm, con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int o = reader.GetInt32(0);
                            int t = GetTotalOfCart(o);
                            string n = GetOwnerNameOfCart(o);
                            result.Add(new Cart()
                            {
                                ownerId = o,
                                ownerName = n,
                                total = t,
                            }); 
                        }
                    }
                }
                con.Close();
            }
            return result;
        }
        public static void PurgeCartOf(int cartId)
        {
            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                string stm = @"DELETE FROM Carts WHERE Owner = @Id";
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(stm, con))
                {
                    cmd.Parameters.AddWithValue("@Id", cartId);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }
        public static List<Product> GetItemsOf(int cartId)
        {
            List<Product> result = new List<Product>();
            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                string stm = @"SELECT 
                                Products.ProductName,
                                Products.Category,
                                Products.Price
                                FROM Carts
                                JOIN Customers ON Customers.Id = Owner
                                JOIN Products  ON Products.Id = Product
                                WHERE Customers.Id = @Id";
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(stm, con))
                {
                    cmd.Parameters.AddWithValue("@Id", cartId);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        { 
                            result.Add(new Product(){
                                ProductName = reader.GetString(0),
                                Category = reader.GetString(1),
                                Price = reader.GetInt32(2)
                            }) ;
                        }
                        
                    }
                }
                con.Close();
            }
            return result;
        }

        private static int GetTotalOfCart(int ownerId)
        {
            int result = 0;
            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                string stm = @"SELECT 
                                SUM(Products.Price) Total
                                FROM Carts
                                JOIN Customers ON Customers.Id = Owner
                                JOIN Products  ON Products.Id = Product
                                WHERE Customers.Id = @Id";
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(stm, con))
                {
                    cmd.Parameters.AddWithValue("@Id", ownerId);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        result = reader.GetInt32(0);
                    }
                }
                con.Close();
            }
            return result;
        }
        private static string GetOwnerNameOfCart(int ownerId)
        {
            string result = "";
            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                string stm = @"SELECT Customers.Fullname
                                FROM Carts
                                JOIN Customers ON Customers.Id = Owner
                                WHERE Customers.Id = @Id";
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(stm, con))
                {
                    cmd.Parameters.AddWithValue("@Id", ownerId);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        result = reader.GetString(0);
                    }
                }
                con.Close();
            }
            return result;
        }

    }
}
