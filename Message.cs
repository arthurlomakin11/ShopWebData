using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWebData
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        public string Fio { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string TextMessage { get; set; }
    }
}
