using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

#nullable disable

namespace ShopWebData
{
    [Table("Products")]
    public partial class Product : INotifyPropertyChanged
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Column(TypeName = "decimal(7, 4)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(7, 4)")]
        public decimal DollarsPrice { get; set; }

        [JsonIgnore]
        public Category Category { get; set; }

        public bool Active { get; set; }

        public List<Image> Images { get; set; }

        [Required]
        public bool Countable { get; set; } = false;

        public int Rating { get; set; }        

        public bool Promotional { get; set; } = false;

        public bool IsGift { get; set; } = false;

        [Column(TypeName = "decimal(3, 2)")]
        public decimal GiftAmount { get; set; } = 0.1M;

        public string VendorCode { get; set; }

        public DateTime CreationDateTime { get; set; } = DateTime.Now;


#pragma warning disable 0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore 0067
    }
}
