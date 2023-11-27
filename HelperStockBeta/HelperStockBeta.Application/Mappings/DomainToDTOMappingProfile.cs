using AutoMapper;
using HelperStockBeta.Application.DTOS;
using HelperStockBeta.Domain.Entities;

namespace HelperStockBeta.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile() 
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
