using System;
using System.Collections.Generic;
using System.Text;
using Toobtech.UserManagement.Business.Model;
using Toobtech.UserManagement.Common;

namespace Toobtech.UserManagement.Business
{
  public  interface IUserRepository
    {
        List<Users> GetUsers();
        bool Insert(Users user);
        bool Update(Users user);
        bool Delete(int id);
    }
}
