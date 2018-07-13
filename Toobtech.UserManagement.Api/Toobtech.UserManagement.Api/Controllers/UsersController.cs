using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Toobtech.UserManagement.Api.Models;
using Toobtech.UserManagement.Business;
using Toobtech.UserManagement.Common;
using Toobtech.UserManagement.Data;

namespace Toobtech.UserManagement.Api.Controllers
{
    [Route("Um")]
    public class UsersController : Controller
    {
       private readonly IUserRepository Repo;
        public UsersController(IUserRepository repo)
        {
            Repo = repo;
        }
        [Route("")]
        [HttpGet]
        public IEnumerable<User> Get()
        {


            return Repo.GetUsers();
        }

    }
}