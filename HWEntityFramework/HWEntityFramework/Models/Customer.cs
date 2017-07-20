using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWEntityFramework.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int CreditCardNumber { get; set; }

        public virtual List<Sale> Sales { get; set; }
    }
}