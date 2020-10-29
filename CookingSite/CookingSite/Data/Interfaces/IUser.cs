using CookingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSite.Data.Interfaces
{
    interface IUser
    {
        public void AddUserDB(User user);
        public IEnumerable<User> AllUsers();
        public void DeleteUser(User user);
        public User GetUserDB(int id);
        public void UpdateUser(User user);
    }
}
