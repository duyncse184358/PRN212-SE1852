using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5_Clone
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Quantity { set; get; }
        public float Price { set; get; }

        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Quantity}\t{Price}";
        }

        public Product clone()
        {
            return MemberwiseClone() as Product;
        }

    }
}
