using Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance;
using Alto_Valyrio.src.Inventory.Warehouses.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Warehouses.Infrastructure.Persistance
{
    public class SQLServerWarehouseRepository : IWarehouseRepository
    {
        public void Save(Warehouse warehouse)
        {
            using var context = new AltoTestContext();

            context.Warehouses.Add(warehouse);
            context.SaveChanges();
        }
    }
}
