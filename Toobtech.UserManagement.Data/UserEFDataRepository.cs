using Ipreo.NS.Permissions.Data.Repository.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Toobtech.UserManagement.Common;

namespace Toobtech.UserManagement.Data
{
    public class UserEFDataRepository : IUserDataRepository
    {
        UsersContext _context;

        public UserEFDataRepository()
        {
            _context = new UsersContext();
        }
          public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            //Type conversion
          
                List<User> users = new List<User>();
            foreach (var item in _context.Users)
            {
                users.Add(new User() { Id = item.Id, Name = item.Name, Description = item.Description });
            }
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
