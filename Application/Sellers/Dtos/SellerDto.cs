using Domain.Common;
using Domain.Enums;

namespace Application.Sellers.Dtos
{
    public class SellerDto : BaseEntityDto
    {
        public string Name { get; set; }
        public DateTimeOffset RegisterDate { get; set; }
        public string Mail { get; set; }
        public SellerType SellerType { get; set; }
    }
}
