using Manasaty_Platform.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Manasaty_Platform.Controllers
{
    internal class UserController
    {
        //private readonly string connectionURL = "Server=Amr_Halima\\SQLEXPRESS;Database=ManasatyPlatform;Integrated Security=True;";
        private readonly string connectionURL = "Server=DESKTOP-EVNJELC\\SQLEXPRESS;Database=ManasatyPlatform;Trusted_Connection=True;";
        public UserController() { }
        public void AddUser() 
        { 

        } 
        public void UpdateUser()
        { 

        }
        public void RemoveUser()
        {

        }
        public List<User> GetUsers()
        {
            return new List<User>();//temp
        }
    }
}
