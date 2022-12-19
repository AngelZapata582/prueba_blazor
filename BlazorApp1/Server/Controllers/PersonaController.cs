using BlazorApp1.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PersonaController(ApplicationDbContext context)
        {
            this._context = context;
        }

        //Get All
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var pers = await _context.Personas.ToListAsync();
            return Ok(pers);
        }

        //GetById
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var pers = await _context.Personas.FirstOrDefaultAsync(a => a.Id == id);
            return Ok(pers);
        }

        //Create
        [HttpPost]
        public async Task<IActionResult> Post(Persona persona)
        {
            _context.Add(persona);
            await _context.SaveChangesAsync();
            return Ok(persona.Id);
        }

        //upadate
        [HttpPut]
        public async Task<IActionResult> Update(Persona persona)
        {
            _context.Entry(persona).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        //delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var per = new Persona { Id = id };
            _context.Remove(per);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
