using LibKengModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KengService.DatabaseContext
{
    public class PGDbContext : DbContext
    {
        public PGDbContext():base (nameOrConnectionString: "DefaultConnectionString") { }
        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Product> Products { get; set; }
    }
}