using Application.Common.Interfaces.Sellers;
using Application.Sellers.Dtos;
using Application.Sellers.Queries;
using AutoMapper;
using MediatR;

namespace Application.Sellers.Handlers.Queries
{
    public class GetSellersQueryHandler : IRequestHandler<GetSellersQuery, List<SellerDto>>
    {
        private readonly ISellerService _sellerService;
        private readonly IMapper _mapper;

        public GetSellersQueryHandler(ISellerService sellerService, IMapper mapper)
        {
            _sellerService = sellerService;
            _mapper = mapper;
        }
        public async Task<List<SellerDto>> Handle(GetSellersQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<SellerDto>>(_sellerService.Query().ToList());
        }
    }
}
