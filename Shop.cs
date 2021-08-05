using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopWebData
{
    public class Shop
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Adress> Adresses { get; set; }
        public List<ShopsAdresses> ShopsAdresses { get; set; }


        public bool ProcessedManually { get; set; }
        public string ImageUri { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkTime { get; set; }
        public string MapsUri { get; set; }
        public string MapsDirectionsUri { get; set; }


        //Delivery Time

        public DateTime StartDeliveryTime { get; set; }
        public DateTime EndDeliveryTime { get; set; }


        //Pickup Time

        public DateTime StartPickupTime { get; set; }
        public DateTime EndPickupTime { get; set; }

        //Shop work type

        public bool Pickup { get; set; }
        public bool Delivery { get; set; }
    }
}