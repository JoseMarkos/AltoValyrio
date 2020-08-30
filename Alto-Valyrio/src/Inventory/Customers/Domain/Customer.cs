﻿using Alto_Valyrio.src.Inventory.Auth.Domain;
using Alto_Valyrio.src.Inventory.Purchases.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Customers.Domain
{
    public sealed class Customer
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
        public int AuthUserId { get; set; }
        public AuthUsername Username { get; set; }
        public AuthPassword Password { get; set; }
    }
}
