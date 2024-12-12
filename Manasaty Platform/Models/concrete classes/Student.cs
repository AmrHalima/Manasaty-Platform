using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manasaty_Platform.Models
{
    internal class Student:User
    {
       
        public string ParentPhone {  get; set; }
        
        public Student()
        {
        }
        public Student( string firstName, string lastName, string email, string password, string gender, string phone, string parentPhone) : base(firstName, lastName, email, password, gender, phone)
        {

            ParentPhone = parentPhone;
        }
        public Student(int id,string firstName, string lastName, string email, string password, string gender,string phone,string parentPhone) :base(id,firstName,lastName,email,password,gender, phone)
        {
            
            ParentPhone = parentPhone;
        }
        public Student(int id, string firstName, string lastName, string email, string password, string gender, string phone, string parentPhone,string userid) : base(id, firstName, lastName, email, password, gender, phone,userid)
        {

            ParentPhone = parentPhone;
        }

    }
}
