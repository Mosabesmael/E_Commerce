using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public required string name { get; set; }
        public required string email { get; set; }
        public required string password { get; set; }
        public Cart? Cart { get; set; }
    }
}
