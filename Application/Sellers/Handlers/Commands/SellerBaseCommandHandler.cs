using Application.Common.GenericHandler;
using Application.Common.Interfaces.Products;
using Application.Common.Interfaces.Sellers;
using Application.Sellers.Commands;
using Application.Sellers.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Sellers.Handlers.Commands
{
    public class SellerBaseCommandHandler :  BaseCommandHandler<SellerBaseCommand, Seller, SellerDto>
    {
        public SellerBaseCommandHandler(ISellerService sellerService, IMapper mapper) : base(sellerService, mapper)
        {

        }
    }
}
