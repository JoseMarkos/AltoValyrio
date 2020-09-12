using Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance;
using Alto_Valyrio.src.Inventory.Warehouses.Domain;
using System.Linq;
using System;

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
#nullable enable
        public Warehouse? Search(string name)
        {
            using var context = new AltoTestContext();

            var match = from warehouse in context.Warehouses
                        where warehouse.Name == name
                        select warehouse;

            return match.FirstOrDefault();
        }

        public Warehouse? SearchLast()
        {
            using var context = new AltoTestContext();
            return context.Warehouses.Last();
        }
#nullable disable
    }
}
