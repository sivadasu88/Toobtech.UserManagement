using System;
using System.Collections.Generic;
using System.Text;
using Toobtech.UserManagement.Common;

namespace Toobtech.UserManagement.Data
{
    public class UserDataRepository : IUserDataRepository
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {x
            List<User> users = new List<User>();
            users.Add(new User() { Id = 1, Name = "User1", Description = "" });
            users.Add(new User() { Id = 2, Name = "User2", Description = "" });
            users.Add(new User() { Id = 3, Name = "User3", Description = "" });
            users.Add(new User() { Id = 4, Name = "User4", Description = "" });
            return users;
        }

        public bool Insert(User user)
        {
            throw new NotImplementedException();
        }

        public bool Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
