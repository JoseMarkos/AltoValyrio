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
        public string PrimerNombre { get; set; }
#nullable enable
        public string? SegundoNombre { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
#nullable disable
        public ICollection<Purchase> Purchases { get; set; }
#nullable enable
        public int? Phone { get; set; }
#nullable disable
        public AuthUsername Username { get; set; }
        public AuthPassword Password { get; set; }
        
        public Roles Role { get; set; }
    }

    public enum Roles
    {
        Administrator,
        Customer
    }
}
