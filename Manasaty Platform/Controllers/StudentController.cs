using Manasaty_Platform.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Manasaty_Platform.Controllers
{
    internal class StudentController
    {
        //private readonly string connectionURL = "Server=Amr_Halima\\SQLEXPRESS;Database=ManasatyPlatform;Integrated Security=True;";
        private readonly string connectionURL = "Server=DESKTOP-EVNJELC\\SQLEXPRESS;Database=ManasatyPlatform;Trusted_Connection=True;";
        public StudentController() { }
        // DB CRUD operations
        public void AddStudent(Student student)//ADD TO THE DB "Create"
        {
            using (var connection = new SqlConnection(connectionURL))
            {
                string query = "INSERT INTO STUDENT (FIRSTNAME, LASTNAME, EMAIL, PASSWORD, GENDER, PHONE, PARENTPHONE) " +
                    "VALUES (@FIRSTNAME,@LASTNAME,@EMAIL,@PASSWORD,@GENDER,@PHONE,@PARENTPHONE) ";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@FIRSTNAME", student.FirstName);
                cmd.Parameters.AddWithValue("@LASTNAME", student.LastName); ;
                cmd.Parameters.AddWithValue("@EMAIL", student.Email);
                cmd.Parameters.AddWithValue("@PASSWORD", student.Password);
                cmd.Parameters.AddWithValue("@GENDER", student.Gender);
                cmd.Parameters.AddWithValue("@PHONE", student.Phone);
                cmd.Parameters.AddWithValue("@PARENTPHONE", student.ParentPhone);

                connection.Open();
                cmd.ExecuteNonQuery();

            }
        }
        public void RemoveStudent(Student student)//REMOVE FROM THE DB "Delete"
        {

        }
        public List<Student> ReadStudents()//READ FROM THE DB "Read"
        {
            List<Student> students = new List<Student>();
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
                       // (int)reader["ID"],
                        (string)reader["FIRSTNAME"],
                        (string)reader["LASTNAME"],
                        (string)reader["EMAIL"],
                        (string)reader["PASSWORD"],
                        (string)reader["GENDER"],
                        (string)reader["PHONE"],
                        (string)reader["PARENTPHONE"]
                        ));
                }

            }
            return students;
        }
        public void UpdateStudent(Student student) //Update Student record in DB "Delete"
        {

        }
    }
}
