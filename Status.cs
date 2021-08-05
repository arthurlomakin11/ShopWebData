using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopWebData
{
    [Owned]
    public class Status
    {
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreationDateTime { get; set; } = DateTime.Now;

        [Column(TypeName = "datetime")]
        public DateTime DeletionDateTime { get; set; } = new DateTime(1800, 1, 1);
        public bool Deleted { get; set; } = false;
    }
}
