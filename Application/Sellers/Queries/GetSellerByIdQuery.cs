using Application.Sellers.Dtos;
using MediatR;

namespace Application.Sellers.Queries
{
    public class GetSellerByIdQuery : IRequest<SellerDto>
    {
        public int Id { get; set; }
    }
}
