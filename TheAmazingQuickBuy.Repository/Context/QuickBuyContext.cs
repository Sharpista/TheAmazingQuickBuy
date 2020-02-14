using Microsoft.EntityFrameworkCore;
using TheAmazingQuickBuy.Domain.Entities;
using TheAmazingQuickBuy.Domain.ObjectValue;
using TheAmazingQuickBuy.Repository.Config;

namespace TheAmazingQuickBuy.Repository.Context
{
    public class QuickBuyContext : DbContext
    { 
        public DbSet<User>Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet <OrderItem> OrderItems{ get; set; }
        public DbSet <FormOfPayment> FormOfPayment  { get; set; }
        public QuickBuyContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new FormPaymentConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
