using System;
using System.ComponentModel.DataAnnotations;

namespace Database.Model
{
    public class ShoppingCart
    {
        
        [Key]
        public int CartId { get; set; }

        public string CartName { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public DateTime Date { get; set; }

    }
}
