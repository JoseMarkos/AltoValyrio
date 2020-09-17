using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.ProductsWarehouses.Applications.Create
{
    public class ProductsWarehouseCommand
    {
        private readonly int ProductId;
        private readonly int WarehouseId;

        public ProductsWarehouseCommand(int productId, int warehouseId)
        {
            ProductId = productId;
            WarehouseId = warehouseId;
        }

        public int GetProductId => ProductId;

        public int GetWarehouseId => WarehouseId;
    }
}
