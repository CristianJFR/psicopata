using Application.Sellers.Commands;
using Application.Sellers.Dtos;
using Application.Sellers.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Products_API.Controllers
{

    [ApiController]
    [Route("api/Skills/[controller]")]
    public class SellerController : BaseController<SellerBaseCommand, SellerDto>
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        [HttpGet]
        public async Task<ActionResult<IQueryable<SellerDto>>> Get()
        {
            try
            {
                GetSellersQuery query = new();
                var queryResult = await Mediator.Send(query);
                return Ok(queryResult);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SellerDto>> GetById([FromRoute] int id)
        {
            try
            {
                GetSellerByIdQuery query = new();
                var queryResult = await Mediator.Send(query);
                return Ok(queryResult);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message });
            }
        }
    }
}
