using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INET_Lab4.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public int Price { get; set; }

    }
}
