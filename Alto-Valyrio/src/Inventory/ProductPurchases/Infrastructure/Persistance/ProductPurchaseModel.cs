using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.ProductPurchases.Infrastructure.Persistance
{
    public class ProductPurchaseModel
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int IdPurchase { get; set; }
    }
}
