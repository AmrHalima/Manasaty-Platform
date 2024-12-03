using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Manasaty_Platform.Models.User;

namespace Manasaty_Platform.Models
{
    internal class Assistant
    {
        public Assistant()
        { }
        public Assistant(int id, string name, string email, string password, Gender gender, string phone) : base(id, name, email, password, gender, phone)
        { }
    }
}
