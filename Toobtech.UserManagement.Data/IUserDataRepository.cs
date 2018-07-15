using System;
using System.Collections.Generic;
using Toobtech.UserManagement.Common;
using Toobtech.UserManagement.Data.Model;

namespace Toobtech.UserManagement.Data
{
    public interface IUserDataRepository
    {
        List<UsersRecord> GetUsers();
        bool Insert(UsersRecord user);
        bool Update(UsersRecord user);
        bool Delete(int id);
    }
}
