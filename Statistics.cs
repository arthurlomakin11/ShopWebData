using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopWebData
{
    public class Statistics
    {
        [Key]
        public int Id { get; set; }

        public int AnonymousUserId { get; set; }

        public string MenuItemName { get; set; }


        public MenuItem MenuItem { get; set; }
        [ForeignKey("MenuItem")]
        public int? MenuItemId { get; set; }


        public Category Category { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }


        public DateTime DateTime { get; set; }
    }
}
