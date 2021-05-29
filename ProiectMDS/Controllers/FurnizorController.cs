using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Services.FurnizorService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Controllers
{
    [Route("api/furnizor")]
    [ApiController]
    public class FurnizorController
    {
        public IFurnizorService _furnizorService { get; set; }
        public FurnizorController(IFurnizorService furnizorService)
        {
            _furnizorService = furnizorService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> EndpointUser(int id)
        {
            Furnizor test = await _furnizorService.Get(id);

            return new OkObjectResult(test);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Furnizor> furnizors= await _furnizorService.GetAll();
            return new OkObjectResult(furnizors);
        }

        [HttpGet("getallselect")]
        public async Task<IActionResult> GetAllAsSelect()
        {
            List<SelectItemDto> furnizors = await _furnizorService.GetAllSelect();
            return new OkObjectResult(furnizors);
        }

        [HttpPost]
        public async Task<IActionResult> Create(FurnizorDto model)
        {
            Furnizor furnizor= new Furnizor()
            {
                Nume = model.Nume,
                Oras = model.Oras,
                Contact = model.Contact
            };
            await _furnizorService.Create(furnizor);

            return new OkObjectResult("Model creat");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(FurnizorDto model, int id)
        {
            Furnizor furnizor= await _furnizorService.Get(id);
            if (model.Nume != furnizor.Nume)
            {
                furnizor.Nume = model.Nume;
            }
            if (model.Oras != furnizor.Oras)
            {
                furnizor.Oras = model.Oras;
            }
            if (model.Contact != furnizor.Contact)
            {
                furnizor.Contact = model.Contact;
            }
            await _furnizorService.Update(furnizor);
            return new OkObjectResult("Model updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Furnizor furnizor= await _furnizorService.Get(id);
            await _furnizorService.Delete(furnizor);
            return new OkObjectResult("Model deleted");
        }

    }
}
