using BlazorApp1.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BlazorApp1.Server.Controllers
{
	[Route("/api/[controller]")]
	[ApiController]
	public class PuestoController: ControllerBase
	{
		private readonly ApplicationDbContext _context;
		
		public PuestoController(ApplicationDbContext context)
		{
			this._context = context;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var p = await _context.Puestos.ToListAsync();
			return Ok(p);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var p = await _context.Puestos.FirstOrDefaultAsync(x => x.Id == id);
			return Ok(p);
		}

		[HttpPost]
		public async Task<IActionResult> Post(Puesto puesto)
		{
			if (puesto.Id == 0)
			{
				_context.Add(puesto);
				await _context.SaveChangesAsync();
			}
			else
			{
				_context.Entry(puesto).State = EntityState.Modified;
				await _context.SaveChangesAsync();
			}
			return Ok(puesto);
		}

		[HttpPut]
		public async Task<IActionResult> Put(Puesto puesto)
		{
			_context.Entry(puesto).State= EntityState.Modified;
			await _context.SaveChangesAsync();
			return Ok(puesto.Id);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			var p = new Puesto { Id = id};
			_context.Remove(p);
			await _context.SaveChangesAsync();
			return NoContent();
		}
	}
}
