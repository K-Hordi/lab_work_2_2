using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_work_2_2
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public float Price { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
