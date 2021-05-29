using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Controllers
{
    [Route("api/mainpage")]
    [ApiController]
    public class MainPageController
    {

        [HttpGet]
        public async Task<IActionResult> test(int id)
        {
            return new OkObjectResult("Ok");
        }
    }
}
