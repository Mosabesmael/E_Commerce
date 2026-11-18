using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public DateTime createAt { get; set; }
        public int userId { get; set; }
        public User User { get; set; } = null!;
        public ICollection<CartItem> CartItem { get; set; } = new List<CartItem>();


    }
}
