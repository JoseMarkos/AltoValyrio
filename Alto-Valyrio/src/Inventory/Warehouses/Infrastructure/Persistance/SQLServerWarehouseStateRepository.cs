using Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance;
using Alto_Valyrio.src.Inventory.Warehouses.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Warehouses.Infrastructure.Persistance
{
    class SQLServerWarehouseStateRepository : IWarehouseStateRepository
    {
        public ICollection<WarehouseState> SearchAll()
        {
            using var context = new AltoTestContext();
            try
            {
                return context.WarehouseStates.ToList();

            }
            catch (Exception)
            {
                return new List<WarehouseState>();
            }
        }
    }
}
