using ShopWebData.Code;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ShopWebData
{
    public class Cart : INotifyPropertyChanged
    {
        [Key]
        public int Id { get; set; }
        public DiscountType Discount { get; set; }

        public string BuyerId { get; set; }
        public User Buyer { get; set; }

        [Required]
        public StatusEnum Status { get; set; } = StatusEnum.InCart;

        [Required]
        public bool Paid { get; set; } = false;

        public bool? OperatorViewed { get; set; } = false;

        [Required]
        public Status CartStatus { get; set; } = new Status();
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
        public List<Gift> Gifts { get; set; } = new List<Gift>();

        public Adress ShopAdress { get; set; }

        public int? ShopId { get; set; }
        public Shop Shop { get; set; }

        public string Adress { get; set; }

        public string Comment { get; set; }


        [Column(TypeName = "decimal(7, 3)")]
        public decimal DeliveryPrice { get; set; }

        [NotMapped]
        public string FullAdress { 
            get
            {
                string fullAdress = "";
                string AdressType = ShopAdress?.AdressType;
                string Name = ShopAdress?.Name;
                string Zones = ShopAdress?.Zones;
                string Parent = ShopAdress?.Parent?.Name;


                if (!string.IsNullOrWhiteSpace(Parent))
                {
                    fullAdress += Parent + " ";
                }
                if (!string.IsNullOrWhiteSpace(AdressType))
                {
                    fullAdress += AdressType + " ";
                }
                if (!string.IsNullOrWhiteSpace(Name))
                {
                    fullAdress += Name + " ";
                }
                if (!string.IsNullOrWhiteSpace(Adress))
                {
                    fullAdress += Adress + " ";
                }
                if (!string.IsNullOrWhiteSpace(Zones))
                {
                    fullAdress += Zones;
                }

                return fullAdress;
            } 
        }
        public string ShopComment { get; set; }
        public decimal Sum => CartItems.Sum(item => item.Sum);
        public decimal DollarsSum => CartItems.Sum(item => item.DollarsSum);
        public decimal DollarsFinalSum => CartItems.Sum(item => item.DollarsFinalSum);

        public decimal FinalSum => CartItems.Sum(item => item.FinalSum);
        public decimal FinalSumWithDelivery => CartItems.Sum(item => item.FinalSum) + DeliveryPrice;

        public string DeliveryTime { get; set; }

        public DeliveryType DeliveryType { get; set; }

        #pragma warning disable 0067

        public event PropertyChangedEventHandler PropertyChanged;

        #pragma warning restore 0067


        // User
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }        
    }

    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum StatusEnum
    {
        [Description("В корзине")]
        InCart = 1,
        [Description("Оформлен")]
        Formalized = 3,
        [Description("Отредактирован пользователем")]
        UserEdited = 4,
        [Description("В работе")]
        InWork = 5,
        [Description("Изменен")]
        Edited = 6,
        [Description("Выполнен")]
        Done = 7,
        [Description("Отменен магазином")]
        ShopsCanceled = 8,
        [Description("Отменен")]
        Canceled = 9
    }
}
