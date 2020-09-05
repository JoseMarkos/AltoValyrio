using Alto_Valyrio.src.Inventory.Users.Domain;
using Alto_Valyrio.src.Inventory.ProductPurchases.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Purchases.Domain
{
    public sealed class Purchase
    {
        public int Id { get; set; }
        public DateTime PurchasePlaced { get; set; }
        public DateTime? PurchaseFulfilled { get; set; }
        public int CustomerId { get; set; }
        public User Customer { get; set; }
        public string State { get; set; }
        public ICollection<ProductPurchase> ProductPurchases { get; set; }
    }
}
