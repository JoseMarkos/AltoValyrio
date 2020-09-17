using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.ProductsWarehouses.Domain
{
    public interface IProductsWarehouseRepository
    {
        void Save(ProductsWarehouse productsWarehouse);
    }
}
