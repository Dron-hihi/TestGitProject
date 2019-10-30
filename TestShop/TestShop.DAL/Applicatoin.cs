namespace TestShop.DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Applicatoin : DbContext
    {
        
        public Applicatoin()
            : base("name=Applicatoin")
        {

        }
        public DbSet<Product> Products { get; set; }

      
    }

  
}