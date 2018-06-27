using System;
using System.Collections.Generic;
using Toobtech.UserManagement.Common;

namespace Toobtech.UserManagement.Data
{
    public interface IUserDataRepository
    {
        List<User> GetUsers();
        bool Insert(User user);
        bool Update(User user);
        bool Delete(int id);
    }
}
