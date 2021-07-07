using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailDatabase.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Availability { get; set; }
        public DateTime ManufacturingDate { get; set; }

        public ICollection<Order> Orders { get; set; }
        public Store Store { get; set; }
    }
}
