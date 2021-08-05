using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

#nullable disable

namespace ShopWebData
{
    [Table("Menu")]
    public partial class MenuItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(30)]
        public string Controller { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Content { get; set; }

        public int SequentialNumber { get; set; }
        public bool Active { get; set; } = true;
        
        public MenuType Type = MenuType.MenuItem;

        public List<Image> Images { get; set; }

        public string Url { get; set; }       
    }

    //Desktop Menu
    public partial class MenuItem
    {
        public bool ShowInMenu { get; set; } = true;

        [JsonIgnore]
        public MenuItem Parent { get; set; }

        public bool HasSubItems { get; set; } = false;

        public bool ShowDropDown { get; set; } = false;
    }

    //Mobile Menu
    public partial class MenuItem
    {
        public bool MobileShowInMenu { get; set; } = true;

        [JsonIgnore]
        public MenuItem MobileParent { get; set; }

        public bool AtTheEndOfTheMenu { get; set; }
    }    
}
