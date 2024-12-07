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
        public Teacher(int id, string FirstName, string LasttName, string email, string password, string gender, string phone) : base(FirstName,LasttName, email, password, gender,phone)
        { }
    }
}
