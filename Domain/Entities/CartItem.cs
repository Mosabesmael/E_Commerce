using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public int quantity { get; set; }
        public decimal unitPrice { get; set; }
        public int cartId { get; set; }
        public int productId { get; set; }
        public Cart Cart { get; set; } = null!;
        public Product Product { get; set; } = null!;
       

    }
}
