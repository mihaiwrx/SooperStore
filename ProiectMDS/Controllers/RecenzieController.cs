using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Services.RecenzieService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Controllers
{
    [Route("api/recenzie")]
    [ApiController]
    public class RecenzieController
    {
        public IRecenzieService _recenzieService { get; set; }
        public RecenzieController(IRecenzieService recenzieService)
        {
            _recenzieService = recenzieService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> EndpointUser(int id)
        {
            Recenzie test = await _recenzieService.Get(id);

            return new OkObjectResult(test);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Recenzie> recenzii = await _recenzieService.GetAll();
            List<RecenzieDto> items = new List<RecenzieDto>();
            foreach(var recenzie in recenzii)
            {
                RecenzieDto item = new RecenzieDto()
                {
                    Id = recenzie.Id,
                    Descriere = recenzie.Descriere,
                    Nota = recenzie.Nota,
                    NumeProdus = recenzie.Produs.Nume,
                    NumeUtilizator = recenzie.NumeUtilizator,
                    ProdusId = recenzie.Produs.Id
                };
                items.Add(item);
            }
            return new OkObjectResult(items);
        }

        [HttpGet("getall/{productId}")]
        public async Task<IActionResult> GetAll(long productId)
        {
            List<Recenzie> recenzii = await _recenzieService.GetAllByProductId(productId);
            List<RecenzieDto> items = new List<RecenzieDto>();
            foreach (var recenzie in recenzii)
            {
                RecenzieDto item = new RecenzieDto()
                {
                    Id = recenzie.Id,
                    Descriere = recenzie.Descriere,
                    Nota = recenzie.Nota,
                    NumeProdus = recenzie.Produs.Nume,
                    NumeUtilizator = recenzie.NumeUtilizator,
                    ProdusId = recenzie.Produs.Id
                };
                items.Add(item);
            }
            return new OkObjectResult(items);
        }

        [HttpPost]
        public async Task<IActionResult> Create(RecenzieDto model)
        {
            Recenzie recenzie = new Recenzie()
            {
                NumeUtilizator = model.NumeUtilizator,
                Nota = model.Nota,
                Descriere = model.Descriere,
                ProdusId = model.ProdusId
            };
            await _recenzieService.Create(recenzie);

            return new OkObjectResult("Model creat");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(RecenzieDto model, int id)
        {
            Recenzie recenzie = await _recenzieService.Get(id);
            if (model.NumeUtilizator != recenzie.NumeUtilizator)
            {
                recenzie.NumeUtilizator = model.NumeUtilizator;
            }
            if (model.Nota != recenzie.Nota)
            {
                recenzie.Nota = model.Nota;
            }
            if (model.Descriere != recenzie.Descriere)
            {
                recenzie.Descriere = model.Descriere;
            }
            if (model.ProdusId != recenzie.ProdusId)
            {
                recenzie.ProdusId = model.ProdusId;
            }
            await _recenzieService.Update(recenzie);
            return new OkObjectResult("Model updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Recenzie recenzie = await _recenzieService.Get(id);
            await _recenzieService.Delete(recenzie);
            return new OkObjectResult("Model deleted");
        }

    }
}
