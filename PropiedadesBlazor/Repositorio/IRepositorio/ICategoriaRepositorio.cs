using System;
using PropiedadesBlazor.Modelos.DTO;

namespace PropiedadesBlazor.Repositorio.IRepositorio
{
	public interface ICategoriaRepositorio
	{
        public Task<IEnumerable<CategoriaDTO>> GetAllCategorias();

        public Task<CategoriaDTO> GetCategoria(int categoriaId);

        public Task<CategoriaDTO> CreatCategpria(CategoriaDTO categoriaDTO);

        public Task<CategoriaDTO> ActualizarCategoria(int cateogiraId, CategoriaDTO categoriaDTO);

        public Task<CategoriaDTO> NombreCategoriaExiste(string nombre);

        public Task<CategoriaDTO> BorrarCategoriaExiste(int categoriaId);

        //public Task<IEnumerable<CategoriaDTO>> GetDropDownCategorias();
    }
}

