using Ipreo.NS.Permissions.Data.Repository.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Toobtech.UserManagement.Common;
using Toobtech.UserManagement.Data.Model;

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
           var res= _context.Users.Where(user => user.Id == id).FirstOrDefault();
            _context.Users.Attach(res);
            _context.Users.Remove(res);
            return true;

        }

        public List<UsersRecord> GetUsers()
        {
            //Type conversion

          return   _context.Users.ToList();
        }

        public bool Insert(UsersRecord user)
        {

            bool res;
            _context.Users.Add(user);
           res=Convert.ToBoolean(_context.SaveChanges());
            return res;
              
        }

        public bool Update(UsersRecord user)
        {
            _context.Attach(user);
            _context.Users.Add(user);
            _context.SaveChanges();
            return true;

        }
    }
}
