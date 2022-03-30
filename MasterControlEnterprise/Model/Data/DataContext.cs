using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model.Data
{
    public class DataContext :DbContext
    {
        /*
         * public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        
        }
        */
        //SETEAR LAS TABLAS ENTIDADES EN LA BASE DE DATOS
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<LogAction> LogActions { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationUser> NotificationUsers { get; set; }
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseProduct> purchaseProducts { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleProduct> SaleProducts { get; set; }
        public DbSet<SecurityQuestion> SecurityQuestions { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            //definir llaves primary keys
            //builder.Entity<User>().HasKey(u => new { u.Id });
            //definir relaciones
            //Users
            builder.Entity<Product>(entity =>
            {
                //añadiendo valores por defecto a columnas de product
                entity.Property(p => p.IVA)
                .HasDefaultValue(true);
                entity.Property(p => p.Inventory)
                .HasDefaultValue(0);
            });
            builder.Entity<PurchaseProduct>(entity =>
            {
                entity.Property(p => p.Seller)
                .HasDefaultValue(false);
            });
            builder.Entity<Sale>(entity =>
            {
                entity.Property(p => p.SaleState)
                .HasDefaultValue(SaleState.PENDING);
            });
            builder.Entity<User>(entity =>
            {
                entity.Property(p => p.UserType)
                .HasDefaultValue(UserType.SELLER);
            });
        }
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var CONFIGURATION = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json").Build();
                optionsBuilder
                    .UseLazyLoadingProxies()
                    .UseMySql(CONFIGURATION["ConnectionsStrings:DefaultConnection"], new MariaDbServerVersion(new Version(10, 4, 24)))
                    .LogTo(Console.WriteLine,Microsoft.Extensions.Logging.LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            }
        }
    }
}
