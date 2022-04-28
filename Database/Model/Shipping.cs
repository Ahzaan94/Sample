using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Shipping
    {
       
        public int ShippingId { get; set; }

        public float ShippingCost { get; set; }

        public string Type { get; set; }

        public string Region { get; set; }
    }
}
