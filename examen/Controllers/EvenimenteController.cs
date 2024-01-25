using examen.Models;
using examen.Models.DTOs;
using Lab4_23.Services.EvenimentService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace examen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvenimenteController : ControllerBase
    {
        private IEvenimentService _EvenimentService;

        public EvenimenteController(IEvenimentService EvenimentService)
        {
            _EvenimentService = EvenimentService;
        }

        [HttpGet]
        public IActionResult GetEvenimentByEvenimentName([FromBody] string Evenimentname)
        {
            return Ok(_EvenimentService.GetAll());
        }

        

    }
}
