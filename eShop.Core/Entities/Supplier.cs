using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Core.Entities
{
    public class Supplier
    {
        public String Code { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public int PhoneNumber { get; set; }
        public String Email { get; set; }
    }
}