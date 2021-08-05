using System.ComponentModel.DataAnnotations;

namespace ShopWebData
{
    public class DeliveryTime
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        /*
            [Column(TypeName = "time")]
            public TimeSpan EndTime { get; set; }
        */

        public bool Active { get; set; }
        public bool CustomTime { get; set; }
    }
}
