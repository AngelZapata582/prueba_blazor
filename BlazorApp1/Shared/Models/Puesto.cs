using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared.Models
{
	public  class Puesto
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Valor requerido.")]
		[StringLength(30, ErrorMessage = "Valor demasiado largo.")]
		public string Value { get; set; }
	}
}
