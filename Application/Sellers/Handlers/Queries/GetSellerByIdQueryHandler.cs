using Application.Common.Interfaces.Sellers;
using Application.Sellers.Dtos;
using Application.Sellers.Queries;
using AutoMapper;
using MediatR;

namespace Application.Sellers.Handlers.Queries
{
    public class GetSellerByIdQueryHandler : IRequestHandler<GetSellerByIdQuery, SellerDto>
    {
        private readonly ISellerService _sellerService;
        private readonly IMapper _mapper;

        public GetSellerByIdQueryHandler(ISellerService sellerService, IMapper mapper)
        {
            _sellerService = sellerService;
            _mapper = mapper;
        }
        public async Task<SellerDto> Handle(GetSellerByIdQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<SellerDto>(_sellerService.Get(request.Id));
        }
    }
}
