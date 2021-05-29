using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Services.CategorieService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Controllers
{
    [Route("api/categorie")]
    [ApiController]
    public class CategorieController
    {
        public ICategorieService _categorieService { get; set; }
        public CategorieController(ICategorieService categorieService)
        {
            _categorieService = categorieService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> EndpointUser(int id)
        {
            Categorie test = await _categorieService.Get(id);
            CategorieDto categorie = new CategorieDto()
            {
                Id = test.Id,
                Nume = test.Nume
            };

            return new OkObjectResult(categorie);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Categorie> categ = await _categorieService.GetAll();
            List<CategorieDto> categorii = new List<CategorieDto>();
            foreach(var categorie in categ)
            {
                CategorieDto item = new CategorieDto()
                {
                    Id = categorie.Id,
                    Nume = categorie.Nume
                };
                categorii.Add(item);
            }
            return new OkObjectResult(categorii);
        }

        [HttpGet("getallselect")]
        public async Task<IActionResult> GetAllAsSelect()
        {
            List<SelectItemDto> categ = await _categorieService.GetAllAsSelect();
            return new OkObjectResult(categ);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategorieDto model)
        {
            Categorie categ = new Categorie()
            {
                Nume = model.Nume
            };
            await _categorieService.Create(categ);

            return new OkObjectResult("Model creat");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(CategorieDto model, int id)
        {
            Categorie categ = await _categorieService.Get(id);
            if (model.Nume != categ.Nume)
            {
                categ.Nume = model.Nume;
            }
            await _categorieService.Update(categ);
            return new OkObjectResult("Model updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Categorie categ = await _categorieService.Get(id);
            await _categorieService.Delete(categ);
            return new OkObjectResult("Model deleted");
        }

    }
}
