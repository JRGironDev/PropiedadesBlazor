using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropiedadesBlazor.Modelos.DTO
{
	public class PropiedadDTO
	{
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(30, MinimumLength = 5, ErrorMessage ="El nombre debe estar entre 5 y 30 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [StringLength(300, MinimumLength = 20, ErrorMessage = "La descripción debe estar entre 20 y 300 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El área es obligatoria")]
        [Range(1, 5000, ErrorMessage = "Debes ingresar un númber válido entre 1 y 5,000")]
        public int Area { get; set; }

        [Required(ErrorMessage = "Las habitaciones son obligatorias")]
        [Range(1, 10, ErrorMessage = "Las habitaciones debe estar entre 1 y 10")]
        public int Habitaciones { get; set; }

        [Required(ErrorMessage = "Los baños son obligatoros")]
        [Range(1, 5, ErrorMessage = "Los baños deben estar entre 1 y 105")]
        public int Banios { get; set; }

        [Required(ErrorMessage = "Los parqueos son obligatorios")]
        [Range(1, 20, ErrorMessage = "Los parqueos deben estar entre 1 y 20")]
        public int Parqueadero { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        public double Precio { get; set; }

        [Required]
        public bool Activo { get; set; }

        //Relación con modelo/tabla categoria

        public virtual Categoria Categoria { get; set; }
    }
}

