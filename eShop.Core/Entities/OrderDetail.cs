using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Core.Entities
{
    public class OrderDetail
    {
        public Guid OrderID { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}