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
        public Teacher(int id, string name, string email, string password, Gender gender, string phone) : base(id, name, email, password, gender,phone)
        { }
    }
}
