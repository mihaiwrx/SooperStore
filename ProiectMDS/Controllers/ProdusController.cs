using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Services.ProdusService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Controllers
{
    [Route("api/produs")]
    [ApiController]
    public class ProdusController
    {
        public IProdusService _produsService { get; set; }
        public ProdusController(IProdusService produsService)
        {
            _produsService = produsService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> EndpointUser(int id)
        {
            Produs produs = await _produsService.Get(id);
            ProdusDto item = new ProdusDto()
            {
                Nume = produs.Nume,
                Descriere = produs.Descriere,
                Stoc = produs.Stoc,
                Pret = produs.Pret,
                FurnizorId = produs.FurnizorId,
                CategorieId = produs.CategorieId
            };
            return new OkObjectResult(produs);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Produs> produse = await _produsService.GetAll();
            List<ProdusDto> items = new List<ProdusDto>();
            foreach(var produs in produse)
            {
                ProdusDto item = new ProdusDto()
                {
                    Id = produs.Id,
                    Descriere = produs.Descriere,
                    Nume = produs.Nume,
                    Pret = produs.Pret,
                    Stoc = produs.Stoc,
                    NumeCategorie = produs.Categorie.Nume,
                    NumeFurnizor = produs.Furnizor.Nume
                };
                items.Add(item);
            }
            return new OkObjectResult(items);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProdusDto model)
        {
            Produs produs = new Produs()
            {
                Nume = model.Nume,
                Descriere = model.Descriere,
                Stoc = model.Stoc,
                Pret = model.Pret,
                FurnizorId = model.FurnizorId,
                CategorieId = model.CategorieId
            };
            await _produsService.Create(produs);

            return new OkObjectResult("Model creat");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(ProdusDto model, int id)
        {
            Produs produs = await _produsService.Get(id);
            if (model.Nume != produs.Nume)
            {
                produs.Nume = model.Nume;
            }
            if (model.Descriere != produs.Descriere)
            {
                produs.Descriere = model.Descriere;
            }
            if (model.Stoc != produs.Stoc)
            {
                produs.Stoc = model.Stoc;
            }
            if (model.Pret != produs.Pret)
            {
                produs.Pret = model.Pret;
            }
            if (model.FurnizorId != produs.FurnizorId)
            {
                produs.FurnizorId = model.FurnizorId;
            }
            if (model.CategorieId != produs.CategorieId)
            {
                produs.CategorieId = model.CategorieId;
            }
            await _produsService.Update(produs);
            return new OkObjectResult("Model updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Produs produs = await _produsService.Get(id);
                await _produsService.Delete(produs);
                return new OkObjectResult("Model deleted");
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }

    }
}
