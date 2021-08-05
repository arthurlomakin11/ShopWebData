using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShopWebData
{
    public class ProductCollection : INotifyPropertyChanged
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; } = true;
        public bool ShowInCart { get; set; }
        public bool ShowOnMainPage { get; set; }

        public List<ProductInCollection> Products { get; set; } = new List<ProductInCollection>();

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class ProductInCollection
    {
        [Key]
        public int Id { get; set; }
        public Product Product { get; set; }
    }
}