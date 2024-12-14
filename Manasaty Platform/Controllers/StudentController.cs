using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Manasaty_Platform.Models;
using Manasaty_Platform.Models.concrete_classes;

namespace Manasaty_Platform.Controllers
{
    internal class StudentController
    {
        //private readonly string connectionURL = "Server=Amr_Halima\\SQLEXPRESS;Database=ManasatyPlatform;Integrated Security=True;";
        private readonly string connectionURL = "Server=AMRHALIMALAPTOP\\SQLEXPRESS;Database=ManasatyPlatform;Trusted_Connection=True;";
        //private readonly string connectionURL = "Server=DESKTOP-EVNJELC\\SQLEXPRESS;Database=ManasatyPlatform;Trusted_Connection=True;";
        public StudentController() { }
        internal string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                // Convert the password string to a byte array
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                // Compute the hash
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                // Convert the hash byte array to a hexadecimal string
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
            }
        }
        public List<Chapter> EnrolledIn(Student student)
        {
            var chapters = new List<Chapter>();

            // SQL query to get chapters the student has taken
            string query = "select NAME,DESCRIPTION,DURATION,LINK from CHAPTER join CHAPTER_TOKEN on CHAPTER.NAME=CHAPTER_TOKEN.CHAPTERNAME WHERE STUDENTID= @ID";

            using (SqlConnection connection = new SqlConnection(connectionURL))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", student.Id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        chapters.Add(/*reader["CHAPTERNAME"].ToString()*/
                            new Chapter
                            {
                                Title = reader.GetString(reader.GetOrdinal("NAME")),
                                Description = reader.GetString(reader.GetOrdinal("DESCRIPTION")),
                                Duration = TimeSpan.Parse(reader.GetString(reader.GetOrdinal("DURATION"))),
                                Link = reader.GetString(reader.GetOrdinal("LINK")),
                            });
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return chapters;
        }
        internal Student StudentFound(string email, string password)
        {
            password = HashPassword(password);
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionURL))
                {
                    connection.Open();

                    string query = @"SELECT ID, FIRSTNAME, LASTNAME, EMAIL, PASSWORD, PHONE, GENDER, USERID, PARENTPHONE 
                             FROM [STUDENT] 
                             WHERE EMAIL = @EMAIL AND PASSWORD = @PASSWORD";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EMAIL", email);
                        command.Parameters.AddWithValue("@PASSWORD", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Student
                                {
                                    Id = reader.IsDBNull(reader.GetOrdinal("ID")) ? 0 : int.TryParse(reader.GetString(reader.GetOrdinal("ID")), out int id) ? id : 0,
                                    FirstName = reader.IsDBNull(reader.GetOrdinal("FIRSTNAME")) ? string.Empty : reader.GetString(reader.GetOrdinal("FIRSTNAME")),
                                    LastName = reader.IsDBNull(reader.GetOrdinal("LASTNAME")) ? string.Empty : reader.GetString(reader.GetOrdinal("LASTNAME")),
                                    Email = reader.IsDBNull(reader.GetOrdinal("EMAIL")) ? string.Empty : reader.GetString(reader.GetOrdinal("EMAIL")),
                                    Password = reader.IsDBNull(reader.GetOrdinal("PASSWORD")) ? string.Empty : reader.GetString(reader.GetOrdinal("PASSWORD")),
                                    Phone = reader.IsDBNull(reader.GetOrdinal("PHONE")) ? string.Empty : reader.GetString(reader.GetOrdinal("PHONE")),
                                    Gender = reader.IsDBNull(reader.GetOrdinal("GENDER")) ? string.Empty : reader.GetString(reader.GetOrdinal("GENDER")),
                                    UserID = reader.IsDBNull(reader.GetOrdinal("USERID")) ? string.Empty : reader.GetString(reader.GetOrdinal("USERID")),
                                    ParentPhone = reader.IsDBNull(reader.GetOrdinal("PARENTPHONE")) ? string.Empty : reader.GetString(reader.GetOrdinal("PARENTPHONE"))
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

            return null; // Return null if no student is found
        }
        // DB CRUD operations
        public void AddStudent(Student student)//ADD TO THE DB "Create"
        {
            try
            {
                using (var connection = new SqlConnection(connectionURL))
                {
                    string query = "INSERT INTO STUDENT (FIRSTNAME, LASTNAME, EMAIL, PASSWORD, GENDER, PHONE, PARENTPHONE, USERID) " +
                        "VALUES (@FIRSTNAME,@LASTNAME,@EMAIL,@PASSWORD,@GENDER,@PHONE,@PARENTPHONE,@USERID) ";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@FIRSTNAME", student.FirstName);
                    cmd.Parameters.AddWithValue("@LASTNAME", student.LastName); ;
                    cmd.Parameters.AddWithValue("@EMAIL", student.Email);
                    cmd.Parameters.AddWithValue("@PASSWORD", student.Password);
                    cmd.Parameters.AddWithValue("@GENDER", student.Gender);
                    cmd.Parameters.AddWithValue("@PHONE", student.Phone);
                    cmd.Parameters.AddWithValue("@PARENTPHONE", student.ParentPhone);
                    cmd.Parameters.AddWithValue("@USERID", "020001");// (020001) IS THE DEFUALT USERID
                    connection.Open();
                    cmd.ExecuteNonQuery();

                }
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show($"An error occurred while connecting to the database: {sqlException.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("error while adding a student");
                return;
            }
            MessageBox.Show("your account created succesfully", "Succesfully created", MessageBoxButtons.OK, MessageBoxIcon.None);

        }
        public void RemoveStudent(Student student)//REMOVE FROM THE DB "Delete"
        {

        }
        public List<Student> ReadStudents()//READ FROM THE DB "Read"
        {
            List<Student> students = new List<Student>();
            try
            {
                using (var connection = new SqlConnection(connectionURL))
                {
                    string query = "SELECT ID,FIRSTNAME, LASTNAME, EMAIL, PASSWORD, GENDER, PHONE, PARENTPHONE, USERID " +
                        "FROM STUDENT";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        students.Add(new Student(
                            (int)reader["ID"],
                            (string)reader["FIRSTNAME"],
                            (string)reader["LASTNAME"],
                            (string)reader["EMAIL"],
                            (string)reader["PASSWORD"],
                            (string)reader["GENDER"],
                            (string)reader["PHONE"],
                            (string)reader["PARENTPHONE"],
                            (string)reader["USERID"]
                            ));
                    }

                }

            }
            catch (SqlException sqlException)
            {
                MessageBox.Show($"An error occurred while connecting to the database: {sqlException.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("error while adding a student");
            }
            return students;
        }
        public void UpdateStudent(Student student) //Update Student record in DB "Delete"
        {

        }
    }
}
