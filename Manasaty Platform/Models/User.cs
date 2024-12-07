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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        
        public User() { }
        protected User(string firstName, string lastname, string email,string password,string gender,string phone)
        {
           // Id = id;
            FirstName = firstName;
            LastName = lastname;
            Email = email;
            Password = password;
            this.Gender = gender;
            Phone = phone;
        }

    }
}
