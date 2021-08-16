using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterPostalAddresses.Models
{
    public class Product
    {
        public Guid id { get; set; }

        public string ProductName { get; set; }


        public string ProductImage { get; set; }

        public int Price { get; set; }

    }
}
