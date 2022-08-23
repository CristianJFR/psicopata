using Application.Common.Interfaces.Products;
using Application.Products.Dtos;
using Application.Products.Queries;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
