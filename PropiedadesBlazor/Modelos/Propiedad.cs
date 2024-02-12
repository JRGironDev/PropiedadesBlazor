using System;
using System.ComponentModel.DataAnnotations;

namespace PropiedadesBlazor.Modelos
{
	public class Propiedad
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Nombre { get; set; }

		[Required]
        public string Descripcion { get; set; }

		[Required]
		public int Area { get; set; }

		[Required]
		public int Habitaciones { get; set; }

		[Required]
		public int Banios { get; set; }

		[Required]
		public int Parqueadero { get; set; }

		[Required]
		public double Precio { get; set; }

		[Required]
		public bool Activo { get; set; }

		public DateTime FechaCreacion { get; set; } = DateTime.Now;

		public DateTime FechaActualizacion { get; set; }

	}
}

