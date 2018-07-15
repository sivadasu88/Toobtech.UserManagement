using System;
using System.Collections.Generic;
using System.Text;
using Toobtech.UserManagement.Common;
using Toobtech.UserManagement.Data.Model;

namespace Toobtech.UserManagement.Data
{
    public class UserDataRepository : IUserDataRepository
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<UsersRecord> GetUsers()
        {
            List<UsersRecord> users = new List<UsersRecord>();
            users.Add(new UsersRecord() { Id = 1, Name = "User1", Description = "" });
            users.Add(new UsersRecord() { Id = 2, Name = "User2", Description = "" });
            users.Add(new UsersRecord() { Id = 3, Name = "User3", Description = "" });
            users.Add(new UsersRecord() { Id = 4, Name = "User4", Description = "" });
            return users;
        }

        public bool Insert(UsersRecord user)
        {
            throw new NotImplementedException();
        }

        public bool Update(UsersRecord user)
        {
            throw new NotImplementedException();
        }
    }
}
