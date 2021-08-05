using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ShopWebData
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }
        public DiscountType Discount { get; set; }
        public Status Status { get; set; } = new Status();

        [Column(TypeName = "decimal(7, 3)")]
        public decimal Quantity { get; set; }
        public int CartId { get; set; }
        [JsonIgnore]
        public Cart Cart { get; set; }
        public int ProductId { get; set; }

        [JsonIgnore]
        public Product Product { get; set; }
        [Column(TypeName = "decimal(7, 3)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(7, 3)")]
        public decimal DollarsPrice { get; set; }


        // Prices Extentions
        [NotMapped]
        public decimal Sum => Product.Price * Quantity;

        [NotMapped]
        public decimal FinalSum => Price * Quantity;

        [NotMapped]
        public decimal DollarsSum => Product.DollarsPrice * Quantity;

        [NotMapped]
        public decimal DollarsFinalSum => DollarsPrice * Quantity;
    }
}
