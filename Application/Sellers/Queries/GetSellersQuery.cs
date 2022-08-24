using Application.Sellers.Dtos;
using MediatR;

namespace Application.Sellers.Queries
{
    public class GetSellersQuery : IRequest<List<SellerDto>>
    {
    }
}
