using api.Dtos;
using AutoMapper;
using Core.Entities;

namespace api.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(d => d.ProductType, options => options.MapFrom(d => d.ProductType.Name))
                .ForMember(d => d.ProductBrand, options => options.MapFrom(d => d.ProductBrand.Name))
                .ForMember(d => d.PictureUrl, options => options.MapFrom<ProductUrlResolver>());
        }
    }
}
