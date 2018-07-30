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
        /// <summary>
        /// PGDbContext
        /// </summary>
        public PGDbContext():base (nameOrConnectionString: "DefaultConnectionString") { }

        /// <summary>
        /// Customers
        /// </summary>
        public virtual DbSet<Customer> Customers { get; set; }

        /// <summary>
        /// Products
        /// </summary>
        public virtual DbSet<Product> Products { get; set; }
    }
}