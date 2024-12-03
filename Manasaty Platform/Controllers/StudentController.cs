﻿using Manasaty_Platform.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manasaty_Platform.Controllers
{
    internal class StudentController
    {
        private readonly string connectionURL = "Server=Amr_Halima\\SQLEXPRESS;Database=ManasatyPlatform;Integrated Security=True;";
        public StudentController() { }
        // DB CRUD operations
        public void AddStudent(Student student)//ADD TO THE DB "Create"
        {
            using (var connection = new SqlConnection(connectionURL))
            {
                string query = "INSERT INTO STUDENT (FIRSTNAME, LASTNAME, EMAIL, PASSWORD, GENDER, PHONE, PARENTPHONE, USERID) " +
                    "VALUES (@FIRSTNAME,@LASTNAME,@EMAIL,@PASSWORD,@GENDER,@PHONE,@PARENTPHONE) ";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@FIRSTNAME",student.FirstName);
                cmd.Parameters.AddWithValue("@LASTNAME", student.LastName); ;
                cmd.Parameters.AddWithValue("@EMAIL",student.Email);
                cmd.Parameters.AddWithValue("@PASSWORD", student.Password);
                cmd.Parameters.AddWithValue("@GENDER", student.gender==User.Gender.Male?'M':'F');
                cmd.Parameters.AddWithValue("@PHONE",student.Phone);
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
            return new List<Student>();
        }
        public void UpdateStudent(Student student) //Update Student record in DB "Delete"
        { 
        
        }
    }
}