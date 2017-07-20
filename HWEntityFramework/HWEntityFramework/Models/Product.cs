using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWEntityFramework.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }

        public virtual List<Sale> Sales { get; set; }
    }
}