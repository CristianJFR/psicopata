using Application.Common.GenericHandler;
using Application.Products.Dtos;

namespace Application.Products.Commands
{
    public class ProductBaseCommand : BaseCommand<ProductDto>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public int UserId { get; set; }
    }
}
