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
        public Student(int id, string name, string email, string password, Gender gender,string phone,string parentPhone) :base(id,name,email,password,gender, phone)
        {
            
            ParentPhone = parentPhone;
        }

    }
}
