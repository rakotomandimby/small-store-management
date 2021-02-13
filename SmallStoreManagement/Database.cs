using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SmallStoreManagement
{
    public class Database
    {
        private static readonly  string cs = @"URI = file:SmallStoreManagement.db";
        public static void InitializeCustomers()
        {
            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                
                string stm = "CREATE TABLE Customers (Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    "                                 Fullname TEXT NOT NULL," +
                    "                                 Password TEXT NOT NULL," +
                    "                                 Address  TEXT NOT NULL," +
                    "                                 Discount INTEGER NOT NULL);";
                con.Open();

                SQLiteCommand cmd = new SQLiteCommand(stm, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    // E3AFED0047B08059D0FADA10F400C1E5
                    stm = "INSERT INTO Customers (Id, Fullname, Password, Address, Discount) VALUES (0, 'Admin', 'E3AFED0047B08059D0FADA10F400C1E5', '', 0);";
                    cmd = new SQLiteCommand(stm, con);
                    cmd.ExecuteNonQuery();

                    stm = "INSERT INTO Customers (Fullname, Password, Address, Discount) VALUES ('Rabe', '6CBACE86AAF2140E446742BFC02B4766', 'VS21BU', 0);";
                    cmd = new SQLiteCommand(stm, con);
                    cmd.ExecuteNonQuery();

                    stm = "INSERT INTO Customers (Fullname, Password, Address, Discount) VALUES ('Rafouts', '596B00604E4B1E73E45B45F10FBEEB80', 'VS21CN', 10);";
                    cmd = new SQLiteCommand(stm, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception)
                {
                    con.Close();
                }
            }
               
            
        }
        public static void InitializeProducts()
        {
            using(SQLiteConnection con = new SQLiteConnection(cs))
            {
                string stm = "CREATE TABLE Products (Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                "                                 ProductName TEXT NOT NULL," +
                "                                 Category  TEXT NOT NULL," +
                "                                 Price INTEGER NOT NULL);";
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(stm, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    stm = "INSERT INTO Products (ProductName, Category, Price) VALUES ('Magnum', 'Frozen', 100);";
                    cmd = new SQLiteCommand(stm, con);
                    cmd.ExecuteNonQuery();

                    stm = "INSERT INTO Products (ProductName, Category, Price) VALUES ('RedLabel', 'Alchohol', 2000);";
                    cmd = new SQLiteCommand(stm, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception)
                {
                    con.Close();
                }
            }
        }

        public static void ClearSession()
        {
            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                string stm = "DELETE FROM CurrentUser;";
                con.Open();

                SQLiteCommand cmd = new SQLiteCommand(stm, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception)
                {
                    con.Close();
                }
            }
        }

        public static void InitializeCurrentUser()
        {
            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                string stm = "CREATE TABLE CurrentUser (Id INTEGER, Fullname TEXT NOT NULL);";
                con.Open();

                SQLiteCommand cmd = new SQLiteCommand(stm, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception)
                {
                    con.Close();
                }
            }
        }
        public static void InitializeCart()
        {
            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                string stm = "CREATE TABLE Carts (Owner INTEGER NOT NULL, Product INTEGER NOT NULL);";
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(stm, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception)
                {
                    con.Close();
                }
            }

        }

        public static bool CheckCredentials(string username, string userpassword)
        {
            bool result = false;
            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                string userpasswordHash = Utils.CreateMD5(userpassword);
                Console.WriteLine(userpassword + " / " + userpasswordHash);
                string stm = "SELECT Fullname, Password FROM Customers WHERE Fullname = @Fullname AND Password = @Password";
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(stm, con))
                {
                    cmd.Parameters.AddWithValue("@Fullname", username);
                    cmd.Parameters.AddWithValue("@Password", userpasswordHash);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result = true;
                        }
                    }
                }
                con.Close();
            }
            return result;
        }
        public static string GetCurrentUser(string what)
        {
            string result = "";
            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                con.Open();
                string stm = "SELECT Id, Fullname FROM CurrentUser";
                using (SQLiteCommand cmd = new SQLiteCommand(stm, con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read()) {
                            if (what.Equals("Name")) { result = reader.GetString(1); }
                            else if (what.Equals("Id")) { result = reader.GetInt32(0).ToString(); }
                        }
                        
                    }
                }
                con.Close();
            }
            return result;
        }
        public static void SetCurrentUser(string username)
        {
            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                con.Open();
                string stm = "SELECT Id, Fullname FROM Customers WHERE Fullname = @Fullname;";
                using (SQLiteCommand cmd = new SQLiteCommand(stm, con))
                {
                    cmd.Parameters.AddWithValue("@Fullname", username);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        int UserId = reader.GetInt32(0);

                        string stm2 = "DELETE FROM CurrentUser";
                        using (SQLiteCommand cmd2 = new SQLiteCommand(stm2, con))
                        {
                            cmd2.ExecuteNonQuery();
                            string stm3 = "INSERT INTO CurrentUser (Id, Fullname) VALUES (@Id, @Fullname);";
                            using (SQLiteCommand cmd3 = new SQLiteCommand(stm3, con))
                            {
                                cmd3.Parameters.AddWithValue("@Fullname", username);
                                cmd3.Parameters.AddWithValue("@Id", UserId);
                                cmd3.ExecuteNonQuery();
                            }
                        }
                    }
                }
                con.Close();
            }
        }

         
    }
}
