using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWebData
{
    [Owned]
    public class DiscountType
    {
        public int Discount { get; set; }

        [Column(TypeName = "decimal(7, 4)")]
        public decimal DiscountAmount { get; set; }
    }
}
