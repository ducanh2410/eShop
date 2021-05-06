using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Core.Entities
{
    public class Product
    {
        public Guid ID { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
    }
}