using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Toobtech.UserManagement.Api.Models;
using Toobtech.UserManagement.Business;
using Toobtech.UserManagement.Business.Model;
using Toobtech.UserManagement.Common;
using Toobtech.UserManagement.Data;

namespace Toobtech.UserManagement.Api.Controllers
{
    [Route("Um")]
    public class UsersController : Controller
    {
       IUserRepository Repo;
        public UsersController(IUserRepository repo)
        {
            Repo = repo;
        }
        [Route("")]
        [HttpGet]
        public IEnumerable<UsersDto> Get()
        {
            List<UsersDto> users = new List<UsersDto>();
            foreach (var user in Repo.GetUsers())
            {
                users.Add(new UsersDto() { Id = user.Id, Name = user.Name, Description = user.Description, CreatedBy = user.CreatedBy, UpdatedBy = user.UpdatedBy, UpdatedTime = user.UpdatedTime, CreatedTime = user.CreatedTime });
            }
            return users;
           
        }
        [HttpPost]
        public bool Insert([FromBody] UsersDto usersDto)
        {
            Users record = new Users {  Name = usersDto.Name, Description = usersDto.Description, CreatedBy = usersDto.CreatedBy, UpdatedBy = usersDto.UpdatedBy, UpdatedTime = usersDto.UpdatedTime, CreatedTime = usersDto.CreatedTime };

           return Repo.Insert(record);
        }
        [HttpPut]
        public bool Update(UsersDto usersDto)
        {
            Users record = new Users { Id = usersDto.Id, Name = usersDto.Name, Description = usersDto.Description, CreatedBy = usersDto.CreatedBy, UpdatedBy = usersDto.UpdatedBy, UpdatedTime = usersDto.UpdatedTime, CreatedTime = usersDto.CreatedTime };

            return Repo.Update(record);

        }
        public bool Delete(int id)
        {
          return  Repo.Delete(id);
        }
        
    }
}