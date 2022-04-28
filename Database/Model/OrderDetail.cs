using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Model
{
    public class OrderDetail
    {
        
        public virtual int OrderId { get; set; }

      
        public virtual int ProductId { get; set; }


       
        [Key]
        public int Quantity { get; set; }

        public string ProductType { get; set; }

        public float Cost { get; set; }

        public float Balance { get; set; }
    }
}
