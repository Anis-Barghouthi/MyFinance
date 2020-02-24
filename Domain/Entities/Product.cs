using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public DateTime DateProd { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public virtual ICollection<Provider> Providers { get; set; }
        public virtual ICollection<Provider> Providers { get; set; }
        public virtual Category Category { get; set; }
        public int? CategoryId { get; set; }

        public string Image { get; set; }
    }
}