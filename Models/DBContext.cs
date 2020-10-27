using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class DBContext:DbContext
    {
        public DBContext()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // other code 
            Database.SetInitializer<DBContext>(null);
            // more code here.
        }
        public DbSet<Customer> Customers { get; set; } // My domain models
        public DbSet<Movie> Movies { get; set; }// My domain models
    }
}