using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Services.CosService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Controllers
{
    [Route("api/cos")]
    [ApiController]
    public class CosController
    {
        public ICosService _cosService { get; set; }
        public CosController(ICosService cosService)
        {
            _cosService = cosService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> EndpointUser(int id)
        {
            Cos test = await _cosService.Get(id);

            return new OkObjectResult(test);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Cos> cosuri = await _cosService.GetAll();
            return new OkObjectResult(cosuri);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CosDto model)
        {
            Cos cos = new Cos()
            {
                UserId = model.UserId,
                ProdusId = model.ProdusId
            };
            await _cosService.Create(cos);

            return new OkObjectResult("Model creat");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(CosDto model, int id)
        {
            Cos cos = await _cosService.Get(id);
            if (model.UserId != cos.UserId)
            {
                cos.UserId = model.UserId;
            }
            if (model.UserId != cos.UserId)
            {
                cos.UserId = model.UserId;
            }
            await _cosService.Update(cos);
            return new OkObjectResult("Model updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Cos cos = await _cosService.Get(id);
            await _cosService.Delete(cos);
            return new OkObjectResult("Model deleted");
        }

    }
}
