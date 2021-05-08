using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Core.Entities
{
    public class Order
    {
        public Guid? OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int Status { get; set; }
    }
}