using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace SmallStoreManagement
{
    public class Customer
    {
        public string Fullname { get; set; }
        public string Address { get; set; }
        public int Discount { get; set; }
        public int Id { get; set; }
        public string Password { get; set; }

        private static readonly string cs = @"URI = file:SmallStoreManagement.db";

        public Customer() { }

        public Customer(int Id)
        {
            this.Id = Id;
            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                string stm = "SELECT Id, Fullname, Address, Discount FROM Customers WHERE Id = @Id;";
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(stm, con))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        this.Fullname = reader.GetString(1);
                        this.Address = reader.GetString(2);
                        this.Discount = reader.GetInt32(3);
                    }
                }
                con.Close();
            }

        }

        public static void AddCustomer(Customer c)
        {
            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                string stm = "INSERT INTO Customers (Fullname, Password, Address, Discount) VALUES (@Fullname, @Password, @Address, @Discount);";
                SQLiteCommand cmd = new SQLiteCommand(stm, con);
                cmd.Parameters.AddWithValue("@Fullname", c.Fullname);
                cmd.Parameters.AddWithValue("@Password", c.Password);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Discount", c.Discount);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }

        public static List<Customer> GetAllCustomers()
        {
            List<Customer> result = new List<Customer>();
            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                string stm = "SELECT Id, Fullname, Address, Discount FROM Customers";
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(stm, con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new Customer()
                            {
                                Id = reader.GetInt32(0),
                                Fullname = reader.GetString(1),
                                Address = reader.GetString(2),
                                Discount = reader.GetInt32(3)
                            });
                        }
                    }
                }
                con.Close();
            }
            return result;
        }

        public void AppendToCart(ListView cartContent)
        {
            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                string stm = "DELETE FROM Carts WHERE Owner = @Owner;"; 
                SQLiteCommand cmd = new SQLiteCommand(stm, con);
                cmd.Parameters.AddWithValue("@Owner", this.Id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                string stm = "INSERT INTO Carts (Owner, Product) VALUES (@Owner, @Product);";
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(stm, con))
                {
                    foreach (ListViewItem item in cartContent.Items)
                    {

                        Product p = (Product)item.Tag;
                        cmd.Parameters.AddWithValue("@Owner", this.Id);
                        cmd.Parameters.AddWithValue("@Product", p.Id);
                        cmd.ExecuteNonQuery();

                    }
                }
                con.Close();
            }
        }
    }
}