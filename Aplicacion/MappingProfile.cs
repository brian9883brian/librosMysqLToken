using AutoMapper;
using Uttt.Micro.Libro.Modelo;

namespace Uttt.Micro.Libro.Aplicacion
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<LibreriaMaterial, LibroMaterialDto>();
        }
    }
}
