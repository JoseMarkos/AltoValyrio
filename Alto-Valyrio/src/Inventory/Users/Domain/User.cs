using Alto_Valyrio.src.Inventory.Auth.Domain;
using Alto_Valyrio.src.Inventory.Purchases.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Users.Domain
{
    public sealed class User
    {
        public int Id { get; set; }
#nullable enable

        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? LastName { get; set; }
        public string? SecondLastName { get; set; }
        public ICollection<Purchase>? Purchases { get; set; }
        public int? Phone { get; set; }
#nullable disable
        public string Username { get; set; }
        public string Password { get; set; }

        public int UserRoleId { get; set; }

        public UserRole UserRole { get; set; }
    }

    public enum Roles
    {
        Administrator,
        Customer
    }
}
