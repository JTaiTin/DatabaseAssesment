using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailDatabase.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        public string Location { get; set; }
        public string Manager { get; set; }

        
        public ICollection<Staff> Staffs { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
