using Alto_Valyrio.src.Inventory.ProductPurchases.Domain;
using Alto_Valyrio.src.Inventory.Users.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Purchases.Infrastructure.Persistance
{
    public class PurchaseModel
    {
        public int Id { get; set; }
        public DateTime PurchasePlaced { get; set; }
        public DateTime? PurchaseFulfilled { get; set; }
        public int CustomerId { get; set; }
        public string State { get; set; }
        public ICollection<ProductPurchase> ProductPurchases { get; set; }
    }
}
