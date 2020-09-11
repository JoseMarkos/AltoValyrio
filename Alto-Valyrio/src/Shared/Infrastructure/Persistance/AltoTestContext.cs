using Alto_Valyrio.src.Inventory.ProductPurchases.Domain;
using Alto_Valyrio.src.Inventory.Purchases.Domain;
using Alto_Valyrio.src.Inventory.Users.Domain;
using Alto_Valyrio.src.Inventory.Warehouses.Domain;
using Microsoft.EntityFrameworkCore;

namespace Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance
{
    public class AltoTestContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<ProductPurchase> ProductPurchases { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<WarehouseAddressState> WarehouseAddressStates { get; set; }
        public DbSet<WarehouseState> WarehouseStates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-8LQEAT9U\\UDEO;database=AltoTestThree;Trusted_Connection=true;");
        }
    }
}
