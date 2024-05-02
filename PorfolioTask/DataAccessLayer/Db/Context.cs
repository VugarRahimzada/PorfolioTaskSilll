using Microsoft.EntityFrameworkCore;
using PorfolioTask.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PorfolioTask.DataAccessLayer.Db
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=VR;Database=PorfolioTaskLast2Db;Trusted_Connection=True;Encrypt=false;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Testmonial> Tests { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<PricingDescription> PricingDescriptions { get; set; }
        public DbSet<Pricing>Pricings { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<ContactMe> ContactMes { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
