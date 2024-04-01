using System;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PropiedadesBlazor.Data;
using PropiedadesBlazor.Modelos;
using PropiedadesBlazor.Modelos.DTO;
using PropiedadesBlazor.Repositorio.IRepositorio;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PropiedadesBlazor.Repositorio
{
    public class IMagenPropiedadRepositorio : IIMagenPropiedadRepositorio
    {
        private readonly ApplicationDbContext _bd;
        private readonly IMapper _mapper;

        public IMagenPropiedadRepositorio(ApplicationDbContext bd, IMapper mapper)
        {
            _bd = bd;
            _mapper = mapper;
        }

        public Task<int> BorrarPropiedadImagenPorIdImagen(int imagenDTO)
        {
            throw new NotImplementedException();
        }

        public Task<int> BorrarPropiedadImagenPorIdPropiedad(int propiedadId)
        {
            throw new NotImplementedException();
        }

        public Task<int> BorrarPropiedadImagenPorUrlImagen(string imageUrl)
        {
            throw new NotImplementedException();
        }

        public Task<int> CrearPropiedadImagen(ImagenPropiedadDTO imagenDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ImagenPropiedadDTO>> GetImagenPropiedad(int propiedadId)
        {
            throw new NotImplementedException();
        }
    }
}

