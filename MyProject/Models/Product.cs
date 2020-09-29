using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public String ProductName { get; set; }

        public int Quantity { get; set; }

        public String Image { get; set; }
    }
}
