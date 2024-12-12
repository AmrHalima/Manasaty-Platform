using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Manasaty_Platform.Models
{
    internal  class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string UserID { get; set; }
        
        public User() { }
        protected User( string firstName, string lastname, string email, string password, string gender, string phone)
        {
            FirstName = firstName;
            LastName = lastname;
            Email = email;
            Password = password;
            this.Gender = gender;
            Phone = phone;
        }
        protected User(int id,string firstName, string lastname, string email,string password,string gender,string phone)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastname;
            Email = email;
            Password = password;
            this.Gender = gender;
            Phone = phone;
        }
        protected User(int id, string firstName, string lastname, string email, string password, string gender, string phone,string userid)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastname;
            Email = email;
            Password = password;
            this.Gender = gender;
            Phone = phone;
            UserID = userid;
        }
        internal static bool IsValidEmail(string email)
        {
            // Regular expression for validating email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        internal static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Define the phone number pattern
            string pattern = @"^01[0-2|5]\d{8}$";

            // Check if the input matches the pattern
            return Regex.IsMatch(phoneNumber, pattern);
        }
    }
}
