using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Core.Entities
{
    public class User
    {
        public Guid UserID { get; set; }
        public String UserName { get; set; }
        public String UserSurNamr { get; set; }
        public int UserPhoneNumber { get; set; }
        public String UserAccount { get; set; }
        public String UserEmail { get; set; }
    }
}