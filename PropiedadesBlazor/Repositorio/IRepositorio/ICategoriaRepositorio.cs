using System;
using PropiedadesBlazor.Modelos.DTO;

namespace PropiedadesBlazor.Repositorio.IRepositorio
{
	public interface ICategoriaRepositorio
	{
        public Task<IEnumerable<CategoriaDTO>> GetAllCategorias();
    }
}

