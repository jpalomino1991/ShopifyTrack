using Microsoft.EntityFrameworkCore;
using ShopifyTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopifyTrack.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerAddress> CustomerAddress { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<ShipAddress> ShipAddress { get; set; }
        public DbSet<BillAddress> BillAddress { get; set; }
        public DbSet<Web> Web { get; set; }
        public virtual DbSet<KellyChild> KellyChild { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder
                .Entity<KellyChild>(eb =>
                {
                    eb.HasNoKey();
                    eb.ToTable("KellyChild");
                });
        }
    }
}
