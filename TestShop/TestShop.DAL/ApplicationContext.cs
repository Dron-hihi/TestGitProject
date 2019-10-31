namespace TestShop.DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
            : base("name=Applicatoin")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}