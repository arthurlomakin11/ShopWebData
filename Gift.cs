using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopWebData
{
    public class Gift
    {
        [Key]
        public int Id { get; set; }

        public Cart Cart { get; set; }

        public Product Product { get; set; }

        [Column(TypeName = "decimal(7, 4)")]
        public decimal ProductPrice { get; set; }

        [Column(TypeName = "decimal(7, 3)")]
        public decimal Amount { get; set; }
    }    
}
