using Alto_Valyrio.src.Inventory.Products.Domain;
using Alto_Valyrio.src.Inventory.Warehouses.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.ProductsWarehouses.Domain
{
    public class ProductsWarehouse
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
