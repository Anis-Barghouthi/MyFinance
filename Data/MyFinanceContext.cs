using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// Package Manager Console:
    /// 1.Enable-Migrations
    /// 2.Add-Migration Image
    /// 3.Update-Database
    public class MyFinanceContext : DbContext
    {
        public MyFinanceContext() : base("Name=Alias") // default Name == Data.MyFinanceContext\(Localdb)\MSSQLLocalDB
        {
        }
                                                        
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Provider> Providers { get; set; }
    }
}