using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Alto_Valyrio.src.Inventory.Purchases.Domain;
using Alto_Valyrio.src.Inventory.Users.Domain;

namespace Alto_Valyrio.src.Inventory.Users.Infrastructure.Persistance
{
    public class UserModel
    {
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
#nullable enable
        public string? SegundoNombre { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
#nullable disable
       // public ICollection<Purchase> Purchases { get; set; }
#nullable enable
        public int? Phone { get; set; }
#nullable disable
        public string Username { get; set; }
        public string Password { get; set; }

        public string Role { get; set; }
    }
}
