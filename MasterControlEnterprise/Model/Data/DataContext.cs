using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        
        }
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

        public protected override void OnModelCreating(ModelBuilder builder)
        {
            //definir llaves primary keys
            //builder.Entity<User>().HasKey(u => new { u.Id });
            //definir relaciones
            //Users
            

        }
    }
}
