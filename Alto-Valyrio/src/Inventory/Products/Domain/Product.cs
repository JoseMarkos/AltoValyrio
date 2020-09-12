using Alto_Valyrio.src.Inventory.Warehouses.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Products.Domain
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int Amount { get; set; }

#nullable enable
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public string? Brand { get; set; }

#nullable disable
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
#nullable enable
        public bool? Refrigerated { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int? LocationId { get; set; }
        public Warehouse? Location { get; set; }
        public double? Weight { get; set; }
        public int? PackingTypeId { get; set; }
        public Packing? PackingType { get; set; }

        public string? Description { get; set; }
#nullable disable
    }
}
