using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWEntityFramework.Models
{
    public class StoreLocation
    {
        public int Id { get; set; }
        public string LocationName { get; set; }

        public virtual List<Sale> Sales { get; set; }
    }
}