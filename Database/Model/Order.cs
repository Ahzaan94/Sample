using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Order
    {
       
        public int OrderId { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateShipped { get; set; }

        public string Status { get; set; }

       
        public virtual int CustomerId { get; set; }


        public virtual string CustomerName { get; set; }
        public virtual string ShipDetails { get; set; }

    }
}
