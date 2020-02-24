using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Provider
    {
        public int Id { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsApproved { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}