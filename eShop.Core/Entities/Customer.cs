using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Core.Entities
{
    public class Customer
    {
        public Guid ID { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public String Address { get; set; }
        public String Email { get; set; }
    }
}