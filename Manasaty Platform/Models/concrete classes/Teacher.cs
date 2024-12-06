using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Manasaty_Platform.Models.User;

namespace Manasaty_Platform.Models
{
    internal class Teacher:User
    {
        public Teacher() { }
        public Teacher(int id, string FirstName, string LasttName, string email, string password, Gender gender, string phone) : base(id,  FirstName,LasttName, email, password, gender,phone)
        { }
    }
}
