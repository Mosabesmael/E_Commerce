using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public required string name  { get; set; }
        public  string ? description  { get; set; }
        public decimal price { get; set; }
        public int stock { get; set; }
        public int categoryId { get; set; }
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
        public Category Category { get; set; } = null!;


    }
}
