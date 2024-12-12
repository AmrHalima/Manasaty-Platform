using Manasaty_Platform.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Manasaty_Platform.Controllers
{
    internal class UserController
    {
        //private readonly string connectionURL = "Server=Amr_Halima\\SQLEXPRESS;Database=ManasatyPlatform;Integrated Security=True;";
        //private readonly string connectionURL = "Server=DESKTOP-EVNJELC\\SQLEXPRESS;Database=ManasatyPlatform;Trusted_Connection=True;";
        private readonly string connectionURL = "Server=AMRHALIMALAPTOP\\SQLEXPRESS;Database=ManasatyPlatform;Trusted_Connection=True;";
        
        public UserController() { }

        
        internal User UserFound(string email, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionURL))
                {
                    connection.Open();

                    string query = @"SELECT ID, FIRSTNAME, LASTNAME, EMAIL, PASSWORD, PHONE, GENDER, TEACHERID 
                             FROM [USER] 
                             WHERE EMAIL = @EMAIL AND PASSWORD = @PASSWORD";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EMAIL", email);
                        command.Parameters.AddWithValue("@PASSWORD", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User
                                {
                                    Id = reader.IsDBNull(reader.GetOrdinal("ID")) ? 0 : int.TryParse(reader.GetString(reader.GetOrdinal("ID")), out int id) ? id : 0,
                                    FirstName = reader.IsDBNull(reader.GetOrdinal("FIRSTNAME")) ? string.Empty : reader.GetString(reader.GetOrdinal("FIRSTNAME")),
                                    LastName = reader.IsDBNull(reader.GetOrdinal("LASTNAME")) ? string.Empty : reader.GetString(reader.GetOrdinal("LASTNAME")),
                                    Email = reader.IsDBNull(reader.GetOrdinal("EMAIL")) ? string.Empty : reader.GetString(reader.GetOrdinal("EMAIL")),
                                    Password = reader.IsDBNull(reader.GetOrdinal("PASSWORD")) ? string.Empty : reader.GetString(reader.GetOrdinal("PASSWORD")),
                                    Phone = reader.IsDBNull(reader.GetOrdinal("PHONE")) ? string.Empty : reader.GetString(reader.GetOrdinal("PHONE")),
                                    Gender = reader.IsDBNull(reader.GetOrdinal("GENDER")) ? string.Empty : reader.GetString(reader.GetOrdinal("GENDER")),
                                    UserID = reader.IsDBNull(reader.GetOrdinal("TEACHERID")) ? string.Empty : reader.GetString(reader.GetOrdinal("TEACHERID")),
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while connecting to the database: {ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null; // Return null if no user is found
        }
        public void AddUser() 
        { 

        } 
        public void UpdateUser()
        { 

        }
        public void RemoveUser()
        {

        }
        public List<User> GetUsers()
        {
            return new List<User>();//temp
        }
    }
}
