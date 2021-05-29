using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Services.ComandaService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Controllers
{
    [Route("api/comanda")]
    [ApiController]
    public class ComandaController
    {
        public IComandaService _comandaService { get; set; }
        public ComandaController(IComandaService comandaService)
        {
            _comandaService = comandaService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> EndpointUser(int id)
        {
            Comanda test = await _comandaService.Get(id);

            return new OkObjectResult(test);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Comanda> comenzi = await _comandaService.GetAll();
            return new OkObjectResult(comenzi);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ComandaDto model)
        {
            Comanda comanda = new Comanda()
            {
                Adresa = model.Adresa,
                CosId = model.CosId
            };
            await _comandaService.Create(comanda);

            return new OkObjectResult("Model creat");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(ComandaDto model, int id)
        {
            Comanda comanda = await _comandaService.Get(id);
            if (model.Adresa != comanda.Adresa)
            {
                comanda.Adresa = model.Adresa;
            }
            if (model.CosId != comanda.CosId)
            {
                comanda.CosId = model.CosId;
            }
            await _comandaService.Update(comanda);
            return new OkObjectResult("Model updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Comanda comanda = await _comandaService.Get(id);
            await _comandaService.Delete(comanda);
            return new OkObjectResult("Model deleted");
        }

    }
}
