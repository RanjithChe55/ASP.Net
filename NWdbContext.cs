using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Codefirst.Models
{
    public class NWdbContext : DbContext
    {
        public NWdbContext()
            : base("Name=NorthWindConnection")
        {

        }
        public DbSet<Category> CategoriesTable { get; set; }
        public DbSet<Product> ProductsTable { get; set; }

    }
}