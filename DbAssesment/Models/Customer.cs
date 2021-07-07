using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailDatabase.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string ContactNumber { get; set; }
        public string address { get; set; }

        public ICollection<Order> Orders { get; set; }
        public Store Store { get; set; }
    }
}
