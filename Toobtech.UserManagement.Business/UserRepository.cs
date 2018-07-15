using System;
using System.Collections.Generic;
using System.Text;
using Toobtech.UserManagement.Business.Model;
using Toobtech.UserManagement.Common;
using Toobtech.UserManagement.Data;
using Toobtech.UserManagement.Data.Model;

namespace Toobtech.UserManagement.Business
{
    public class UserRepository : IUserRepository
    {
      IUserDataRepository Repo;
        public UserRepository(IUserDataRepository repo)
        {
            Repo = repo;
        }

        public bool Delete(int id)
        {
            return Repo.Delete(id);
        }

        public List<Users> GetUsers()
        {
            List<Users> users = new List<Users>();
            foreach (var user in Repo.GetUsers())
            {
                users.Add(new Users() { Id = user.Id, Name = user.Name, Description = user.Description, CreatedBy = user.CreatedBy, UpdatedBy = user.UpdatedBy, UpdatedTime = user.UpdatedTime, CreatedTime = user.CreatedTime });
            }
            return users;

        }

        public bool Insert(Users user)
        {
            UsersRecord record = new UsersRecord { Id = user.Id, Name = user.Name, Description = user.Description, CreatedBy = user.CreatedBy, UpdatedBy = user.UpdatedBy, UpdatedTime = user.UpdatedTime, CreatedTime = user.CreatedTime };
            return Repo.Insert(record);
        }

        public bool Update(Users user)
        {
            UsersRecord record = new UsersRecord { Id = user.Id, Name = user.Name, Description = user.Description, CreatedBy = user.CreatedBy, UpdatedBy = user.UpdatedBy, UpdatedTime = user.UpdatedTime, CreatedTime = user.CreatedTime };
            return Repo.Update(record);
        }
    
    }
}
