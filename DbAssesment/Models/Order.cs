using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailDatabase.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}
