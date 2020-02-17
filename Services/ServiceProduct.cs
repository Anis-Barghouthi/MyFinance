using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceProduct : IServiceProduct
    {
        MyFinanceContext ctx;

        public ServiceProduct()
        {
            ctx = new MyFinanceContext();
        }

        public void AddProduct(Product p)
        {
            ctx.Products.Add(p);
        }

        public void RemoveProduct(Product p)
        {
            ctx.Products.Remove(p);
        }

        public void Commit()
        {
            ctx.SaveChanges();
        }
    }
}
