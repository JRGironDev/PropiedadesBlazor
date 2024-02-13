using System;
using PropiedadesBlazor.Modelos.DTO;

namespace PropiedadesBlazor.Repositorio.IRepositorio
{
	public interface IIMagenPropiedadRepositorio
	{
		public Task<int> CrearPropiedadImagen(ImagenPropiedadDTO imagenDTO);

		public Task<int> BorrarPropiedadImagenPorIdImagen(int imagenDTO);

		public Task<int> BorrarPropiedadImagenPorIdPropiedad(int propiedadId);

		public Task<int> BorrarPropiedadImagenPorUrlImagen(string imageUrl);

		public Task<IEnumerable<ImagenPropiedadDTO>> GetImagenPropiedad(int propiedadId);
	}
}

