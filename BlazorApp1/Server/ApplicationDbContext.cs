using BlazorApp1.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Server
{
	public class ApplicationDbContext: DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
		{

		}

		public DbSet<Persona> Personas { get; set; }

		public DbSet<Puesto> Puestos { get; set; }
	}
}
