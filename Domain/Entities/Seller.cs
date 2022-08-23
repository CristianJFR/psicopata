using Domain.Bases;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Seller : BaseEntity
    {
        public string Name { get; set; }
        public DateTimeOffset RegisterDate { get; set; }
        public string Mail { get; set; }
        public SellerType SellerType { get; set; }
    }
}
