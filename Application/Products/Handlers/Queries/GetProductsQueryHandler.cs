using Application.Common.Interfaces.Products;
using Application.Products.Dtos;
using Application.Products.Queries;
using AutoMapper;
using MediatR;

namespace Application.Products.Handlers.Queries
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IQueryable<ProductDto>>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public GetProductsQueryHandler(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        public async Task<IQueryable<ProductDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<IQueryable<ProductDto>>(_productService.Query());
        }
    }
}
