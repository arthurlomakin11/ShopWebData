using System.ComponentModel.DataAnnotations;

namespace ShopWebData
{
    public class UserAdress
    {
        [Key]
        public int Id { get; set; }

        public Adress ShopAdress { get; set; }

        public string Adress { get; set; }

        public User User { get; set; }
    }
}
