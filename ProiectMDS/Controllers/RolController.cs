using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Services.RolService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Controllers
{
    [Route("api/rol")]
    [ApiController]
    public class RolController
    {
        public IRolService _rolService { get; set; }
        public RolController(IRolService rolService)
        {
            _rolService = rolService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> EndpointUser(int id)
        {
            Rol test = await _rolService.Get(id);

            return new OkObjectResult(test);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Rol> roluri = await _rolService.GetAll();
            return new OkObjectResult(roluri);
        }

        [HttpPost]
        public async Task<IActionResult> Create(RolDto model)
        {
            Rol rol = new Rol()
            {
                Nume = model.Nume
            };
            await _rolService.Create(rol);

            return new OkObjectResult("Model creat");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(RolDto model, int id)
        {
            Rol rol = await _rolService.Get(id);
            if (model.Nume != rol.Nume)
            {
                rol.Nume = model.Nume;
            }
            await _rolService.Update(rol);
            return new OkObjectResult("Model updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Rol rol= await _rolService.Get(id);
            await _rolService.Delete(rol);
            return new OkObjectResult("Model deleted");
        }

    }
}
