using System.ComponentModel.DataAnnotations;

namespace ShopWebData
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Key { get; set; }

        public string Value { get; set; }
    }
}
