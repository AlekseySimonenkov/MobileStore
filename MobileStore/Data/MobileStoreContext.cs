using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MobileStore.Models;

namespace MobileStore.Data
{
    public class MobileStoreContext : DbContext
    {
        public MobileStoreContext (DbContextOptions<MobileStoreContext> options)
            : base(options)
        {
        }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Client> Clients { get; set; }
        //public DbSet<Cart> Carts { get; set; }
        public DbSet<AboutPhone> AboutPhones { get; set; }
        public DbSet<AboutClient> AboutClient { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Phone>().ToTable("Phone");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<AboutClient>().ToTable("AboutClient");
            modelBuilder.Entity<AboutPhone>().ToTable("AboutPhone");

        }
        public DbSet<MobileStore.Models.Phone>? Phone { get; set; }
        public DbSet<MobileStore.Models.Client>? Client { get; set; }
    }
}
