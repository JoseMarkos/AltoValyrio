using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance
{
    public class AuthContext : DbContext
    {
        public DbSet<AuthUserModel> AuthUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-8LQEAT9U\\UDEO;database=AuthTest;Trusted_Connection=true;");
        }
    }
}
