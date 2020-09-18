using Alto_Valyrio.src.Inventory.Products.Domain;
using Alto_Valyrio.src.Inventory.Purchases.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.ProductPurchases.Domain
{
    public class ProductPurchase
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int PurchaseId { get; set; }
        public Purchase Purchase { get; set; }
    }
}
