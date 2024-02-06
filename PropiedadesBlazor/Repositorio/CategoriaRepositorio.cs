using System;
using AutoMapper;
using PropiedadesBlazor.Data;
using PropiedadesBlazor.Modelos;
using PropiedadesBlazor.Modelos.DTO;
using PropiedadesBlazor.Repositorio.IRepositorio;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PropiedadesBlazor.Repositorio
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly ApplicationDbContext _bd;
        private readonly IMapper _mapper;

        public CategoriaRepositorio(ApplicationDbContext bd, IMapper mapper)
        {
            _bd = bd;
            _mapper = mapper;
        }

        public async Task<CategoriaDTO> ActualizarCategoria(int categoriaId, CategoriaDTO categoriaDTO)
        {
            try
            {
                if (categoriaId == categoriaDTO.Id)
                {
                    //Valido para actualizar
                    Categoria categoria = await _bd.Categoria.FindAsync(categoriaId);
                    Categoria cate = _mapper.Map<CategoriaDTO, Categoria>(categoriaDTO, categoria);
                    cate.FechaActualizacion = DateTime.Now;
                    var categoriaActualizada = _bd.Categoria.Update(cate);
                    await _bd.SaveChangesAsync();
                    return _mapper.Map<Categoria, CategoriaDTO>(categoriaActualizada.Entity); 
                }
                else
                {
                    //Inválido
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Task<CategoriaDTO> BorrarCategoriaExiste(int categoriaId)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoriaDTO> CrearCategoria(CategoriaDTO categoriaDTO)
        {
            Categoria categoria = _mapper.Map<CategoriaDTO, Categoria>(categoriaDTO);
            categoria.FechaActualizacion = DateTime.Now;
            var categoriaAgregada = await _bd.Categoria.AddAsync(categoria);
            await _bd.SaveChangesAsync();
            return _mapper.Map<Categoria, CategoriaDTO>(categoriaAgregada.Entity);

        }

        public Task<IEnumerable<CategoriaDTO>> GetAllCategorias()
        {
            throw new NotImplementedException();
        }

        public Task<CategoriaDTO> GetCategoria(int categoriaId)
        {
            throw new NotImplementedException();
        }

        public Task<CategoriaDTO> NombreCategoriaExiste(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}

