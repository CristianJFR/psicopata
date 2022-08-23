using Application.Sellers.Commands;
using Application.Sellers.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Sellers.Mappings
{
    public class SellerMappingProfile : Profile
    {
        public SellerMappingProfile()
        {
            CreateMap<SellerDto, Seller>().ReverseMap();
            CreateMap<SellerBaseCommand, SellerDto>().ReverseMap();
        }
    }
}
