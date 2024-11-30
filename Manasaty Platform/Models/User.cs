using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manasaty_Platform.Models
{
    internal abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public enum Gender
        {
            Male,Female
        }
        public Gender gender { get; set; }
        protected User(int id,string name,string email,string password,Gender gender,string phone)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            this.gender = gender;
            Phone = phone;
        }

    }
}
