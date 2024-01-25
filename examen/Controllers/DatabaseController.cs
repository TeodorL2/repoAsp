using examen.Data;
using examen.Models;
using examen.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.CompilerServices;

namespace examen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseController : ControllerBase
    {
        private readonly ExamenContext _examenContext;

        public DatabaseController(ExamenContext examenContext)
        {
            _examenContext = examenContext;
        }

        /*[HttpGet("modelAll")]
        public async Task<IActionResult> GetModel()
        {
            return Ok(await _examenContext.models.ToListAsync());
        }

        [HttpGet("model")]
        public async Task<IActionResult> GetById(Guid _id)
        {
            model model1ById = await _examenContext.models.FirstOrDefaultAsync(x => x.Id.Equals(_id));
            return Ok(model1ById);
        }*/
    }
}
