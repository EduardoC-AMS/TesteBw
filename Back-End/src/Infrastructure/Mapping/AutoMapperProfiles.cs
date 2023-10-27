using AutoMapper;
using Domain.Entity;
using Domain.Models;

namespace Infrastructure.Mapping
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
           CreateMap<Category, CategoryModel>().ReverseMap();

           CreateMap<Product, ProductModel>().ReverseMap();

        }
    }
}