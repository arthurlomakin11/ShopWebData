using ShopWebData.Code;
using System.ComponentModel;

namespace ShopWebData
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum DeliveryType : byte
    {
        [Description("Доставка")]
        Delivery,
        [Description("Самовывоз")]
        Pickup
    }
}
