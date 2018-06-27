using System;
using System.Collections.Generic;
using System.Text;
using Toobtech.UserManagement.Common;

namespace Toobtech.UserManagement.Business
{
  public  interface IUserRepository
    {
        List<User> GetUsers();
        bool Insert(User user);
        bool Update(User user);
        bool Delete(int id);
    }
}
