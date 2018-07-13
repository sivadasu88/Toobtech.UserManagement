using System;
using System.Collections.Generic;
using System.Text;
using Toobtech.UserManagement.Common;
using Toobtech.UserManagement.Data;

namespace Toobtech.UserManagement.Business
{
    public class UserRepository : IUserRepository
    {
       private readonly IUserDataRepository Repo;
        public UserRepository(IUserDataRepository repo)
        {
            Repo = repo;
        }
        public bool Delete(int id)
        {
          return  Repo.Delete(id);
        }

        public List<User> GetUsers()
        {
            return Repo.GetUsers();
        }

        public bool Insert(User user)
        {
           return Repo.Insert(user);
        }

        public bool Update(User user)
        {
           return Repo.Update(user);
        }
    }
}
