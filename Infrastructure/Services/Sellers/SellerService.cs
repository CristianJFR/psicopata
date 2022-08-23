using Application.Common.Interfaces.Sellers;
using Domain.Entities;
using Infrastructure.Context;
using Infrastructure.Services.Generic;

namespace Infrastructure.Services.Sellers
{
    public class SellerService : BaseCrudService<Seller>, ISellerService
    {
        public SellerService(ProductsDbContext context) : base(context)
        {

        }
    }
}
