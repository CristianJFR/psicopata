using Application.Common.GenericHandler;
using Application.Sellers.Dtos;
using Domain.Enums;

namespace Application.Sellers.Commands
{
    public class SellerBaseCommand : BaseCommand<SellerDto>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset RegisterDate { get; set; }
        public string Mail { get; set; }
        public SellerType SellerType { get; set; }
    }
}
