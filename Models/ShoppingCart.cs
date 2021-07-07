using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitBazar.Models
{
    public class ShoppingCart
    {
        public int id { get; set; }
        public String fruit_name { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
    }
}
