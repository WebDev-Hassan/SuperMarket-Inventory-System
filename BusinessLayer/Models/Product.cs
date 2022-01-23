using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Title  { get; set; }
        public int Quantity { get; set; }
        public double SalePrice { get; set; }
        public double PurchasePrice { get; set; }
    }
}
