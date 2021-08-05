using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ShopWebData
{
    public class Adress
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }
        public string AdressType { get; set; }
        public string Zones { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return $"{AdressType} {Name} {Zones}";
            }
        }
        public ICollection<Shop> Shops { get; set; }
        public List<ShopsAdresses> ShopAdresses { get; set; }

        [JsonIgnore]
        public Adress Parent { get; set; }
    }
}
