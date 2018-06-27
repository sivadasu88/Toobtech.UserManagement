using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Toobtech.UserManagement.Api.Models;
using Toobtech.UserManagement.Business;
using Toobtech.UserManagement.Common;

namespace Toobtech.UserManagement.Api.Controllers
{
    [Produces("application/json")]
    [Route("Users")]
    public class UsersController : Controller
    {
        IUserRepository Repo = new UserRepository();

        [Route("")]
        [HttpGet]
        public IEnumerable<User> Get()
        {


            return Repo.GetUsers();
        }

    }
}