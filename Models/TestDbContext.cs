using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace test111binimoy.Models
{
    public class TestDbContext: DbContext
    {
        public TestDbContext() : base("test111binimoy") 
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
            modelBuilder.Conventions
              .Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions
              .Remove<ManyToManyCascadeDeleteConvention>();
        }
        public DbSet<Users> Users { get; set; }
    }
}