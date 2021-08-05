using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ShopWebData
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        public string Url { get; set; }

        [JsonIgnore]
        public Product Product { get; set; }
        public int ProductId { get; set; }


        [JsonIgnore]
        public Category Category { get; set; }

        [JsonIgnore]
        public MenuItem MenuItem { get; set; }
    }
}
