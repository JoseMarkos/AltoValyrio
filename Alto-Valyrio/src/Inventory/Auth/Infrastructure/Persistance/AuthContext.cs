using Alto_Valyrio.src.Inventory.ProductPurchases.Domain;
using Alto_Valyrio.src.Inventory.ProductPurchases.Infrastructure.Persistance;
using Alto_Valyrio.src.Inventory.Purchases.Domain;
using Alto_Valyrio.src.Inventory.Purchases.Infrastructure.Persistance;
using Alto_Valyrio.src.Inventory.Users.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance
{
    public class AuthContext : DbContext
    {
        public DbSet<AuthUserModel> AuthUsers { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<UserRoleModel> UserRoles { get; set; }
        public DbSet<PurchaseModel> Purchases { get; set; }
        public DbSet<ProductPurchaseModel> ProductPurchases { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-8LQEAT9U\\UDEO;database=AuthTest;Trusted_Connection=true;");
        }
    }
}
