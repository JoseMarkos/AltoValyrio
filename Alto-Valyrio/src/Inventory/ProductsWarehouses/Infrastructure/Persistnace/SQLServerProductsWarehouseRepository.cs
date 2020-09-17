using Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance;
using Alto_Valyrio.src.Inventory.ProductsWarehouses.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.ProductsWarehouses.Infrastructure.Persistnace
{
    public class SQLServerProductsWarehouseRepository
    {
        public void Save(ProductsWarehouse productsWarehouse)
        {
            using var context = new AltoTestContext();

            context.ProductsWarehouses.Add(productsWarehouse);
            context.SaveChanges();
        }
    }
}
