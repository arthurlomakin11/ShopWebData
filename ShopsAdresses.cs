using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWebData
{
    public class ShopsAdresses
    {
        public int SequentialNumber { get; set; }

        public int ShopId { get; set; }
        public Shop Shop { get; set; }

        public int AdressId { get; set; }
        public Adress Adress { get; set; }
    }
}
