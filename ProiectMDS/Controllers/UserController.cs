using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Services.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController
    {
        public IUserService _userService { get; set; }
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> EndpointUser(int id)
        {
            User test = await _userService.Get(id);

            return new OkObjectResult(test);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<User> users = await _userService.GetAll();
            return new OkObjectResult(users);
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserDto model)
        {
            User user = new User()
            {
                Nume = model.Nume,
                Prenume = model.Prenume,
                Email = model.Email,
                RolId = model.RolId
            };
            await _userService.Create(user);

            return new OkObjectResult("Model creat");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(UserDto model, int id)
        {
            User user = await _userService.Get(id);
            if (model.Nume != user.Nume)
            {
                user.Nume = model.Nume;
            }
            if (model.Prenume != user.Prenume)
            {
                user.Prenume = model.Prenume;
            }
            if (model.Email != user.Email)
            {
                user.Email = model.Email;
            }
            if(model.RolId != user.RolId)
            {
                user.RolId = model.RolId;
            }
            await _userService.Update(user);
            return new OkObjectResult("Model updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            User user = await _userService.Get(id);            
            await _userService.Delete(user);
            return new OkObjectResult("Model deleted");
        }

    }
}
