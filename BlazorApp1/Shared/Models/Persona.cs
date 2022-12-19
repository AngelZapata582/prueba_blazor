using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared.Models
{
	public class Persona
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Lastname { get; set; }
		public DateTime Birthdate { get; set;}
		public string Email { get; set; }
		public string Phone { get; set; }
		public int Experience { get; set; }
	}
}
