using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailDatabase.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string ContactNumber { get; set; }
        public string address { get; set; }

        public Store Store { get; set; }
    }
}
