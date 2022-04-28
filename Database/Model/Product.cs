using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Product
    {
      
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Information { get; set; }

        public float price { get; set; }

    }
}
