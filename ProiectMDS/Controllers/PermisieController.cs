using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Services.PermisieService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Controllers
{
    [Route("api/permisie")]
    [ApiController]
    public class PermisieController
    {
        public IPermisieService _permisieService { get; set; }
        public PermisieController(IPermisieService permisieService)
        {
            _permisieService = permisieService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> EndpointUser(int id)
        {
            Permisie test = await _permisieService.Get(id);

            return new OkObjectResult(test);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Permisie> permisii = await _permisieService.GetAll();
            return new OkObjectResult(permisii);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PermisieDto model)
        {
            Permisie permisie = new Permisie()
            {
                Nume = model.Nume,
                Descriere = model.Descriere
            };
            await _permisieService.Create(permisie);

            return new OkObjectResult("Model creat");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(PermisieDto model, int id)
        {
            Permisie permisie = await _permisieService.Get(id);
            if (model.Nume != permisie.Nume)
            {
                permisie.Nume = model.Nume;
            }
            if (model.Descriere != permisie.Descriere)
            {
                permisie.Descriere = model.Descriere;
            }
            await _permisieService.Update(permisie);
            return new OkObjectResult("Model updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Permisie permisie = await _permisieService.Get(id);
            await _permisieService.Delete(permisie);
            return new OkObjectResult("Model deleted");
        }

    }
}
