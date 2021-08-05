using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

#nullable disable

namespace ShopWebData
{
    [Table("Categories")]
    public partial class Category : INotifyPropertyChanged
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [JsonIgnore]
        public Category Parent { get; set; }

        public int Rating { get; set; }

        public bool ShowText { get; set; } = true;
        public bool Active { get; set; }
        public List<Image> Images { get; set; }
        public virtual List<Product> Products { get; set; } = new List<Product>();

        public bool IsSmart { get; set; }
        public string SmartQuery { get; set; }

#pragma warning disable 0067

        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore 0067
    }
}
