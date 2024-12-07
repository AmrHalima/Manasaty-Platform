using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Manasaty_Platform.Models.User;

namespace Manasaty_Platform.Models
{
    internal class Assistant:User
    {
        public Assistant()
        { }
        public Assistant(int id, string firstName, string lastName, string email, string password, string gender, string phone, string parentPhone) : base(firstName, lastName, email, password, gender, phone)
        { }
    }
}
