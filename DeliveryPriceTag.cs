using System.ComponentModel.DataAnnotations;

namespace ShopWebData
{
    public class DeliveryPriceTag
    {
        [Key]
        public int Id { get; set; }

        public int Price { get; set; }

        public int StartCartPrice { get; set; }
    }
}
