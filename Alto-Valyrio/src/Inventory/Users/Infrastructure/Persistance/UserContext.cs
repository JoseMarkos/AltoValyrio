using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Customers.Infrastructure.Persistance
{
    public sealed class CustomerContext : DBContext
    {
        public DbSet<UserModel> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-8LQEAT9U\\UDEO;database=AuthTest;Trusted_Connection=true;");
        }
    }
}
