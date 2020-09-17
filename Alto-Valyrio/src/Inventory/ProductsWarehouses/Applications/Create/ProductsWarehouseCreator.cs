using Alto_Valyrio.src.Inventory.ProductsWarehouses.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.ProductsWarehouses.Applications.Create
{
    public class ProductsWarehouseCreator
    {
        private readonly IProductsWarehouseRepository Repository;

        public ProductsWarehouseCreator(IProductsWarehouseRepository repository)
        {
            Repository = repository;
        }

        public void Create(int productId, int warehouseId)
        {
            var productWarehouse = new ProductsWarehouse()
            {
                ProductId = productId,
                WarehouseId = warehouseId
            };

            Repository.Save(productWarehouse);
        }
    }
}
