using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcProyectoWeb.Models
{
	public class Almacen
	{
		[Key]
		public int Id { get; set; }
		public string NombreAlmacen { get; set; }
		public string Direccion { get; set; }
		public string UrlImagen { get; set; }
		public int Orden { get; set; }

	}

}
