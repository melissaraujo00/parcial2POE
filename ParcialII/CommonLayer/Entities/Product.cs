using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Product
    {
        public int idProduct {  get; set; }
        public string nameProducto { get; set; }
        public int stock {  get; set; }
        public decimal price { get; set; }
        public int idCategory { get; set; }
    }
}
