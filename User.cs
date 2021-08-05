using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

#nullable disable

namespace ShopWebData
{
    [Table("Users")]
    [Index("PhoneNumber")]
    public partial class User : IdentityUser
    {

        [Key]
        [MaxLength(128)]
        public override string Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Fio { get; set; }

        [Required]
        [MaxLength(15)]
        public override string PhoneNumber { get; set; }

        [EmailAddress]
        public override string Email { get; set; }

        public List<Cart> Carts { get; set; } = new List<Cart>();

        [NotMapped]
        public Cart CurrentCart
        {
            get
            {
                return Carts.FirstOrDefault(cart => 
                    cart.CartStatus.Deleted == false &&
                    cart.Paid == false &&
                    cart.Status == StatusEnum.InCart
                );
            }
        }

        [NotMapped]
        public string LastCartAdress
        {
            get
            {
                Cart Cart = Carts
                    .Where(cart => cart.ShopAdress != null)
                    .OrderByDescending(c => c.CartStatus.CreationDateTime)
                    .FirstOrDefault();

                return Cart?.Adress;
            }
        }

        [NotMapped]
        public string LastCartFullAdress
        {
            get
            {
                Cart Cart = Carts
                    .Where(cart => cart.ShopAdress != null)
                    .OrderByDescending(c => c.CartStatus.CreationDateTime)
                    .FirstOrDefault();

                return Cart?.FullAdress;
            }
        }

        [NotMapped]
        public Adress LastCartShopAdress
        {
            get
            {
                Cart Cart = Carts
                    .Where(cart => cart.ShopAdress != null)
                    .OrderByDescending(c => c.CartStatus.CreationDateTime)
                    .FirstOrDefault();

                return Cart?.ShopAdress;
            }
        }

        public Adress ShopAdress { get; set; }

        public string Adress { get; set; }

        public List<UserAdress> Adresses { get; set; }

        public bool? IsTemporary { get; set; } = false;

        public bool IsLegalEntity { get; set; } = false;
        public string OrganizationName { get; set; }

        public string LegalEntityID { get; set; }
    }
}