using Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance;
using Alto_Valyrio.src.Inventory.Warehouses.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Warehouses.Infrastructure.Persistance
{
    public class SQLServerWarehouseAddressStateRepository : IWarehouseAddressStateRepository
    {
        public ICollection<WarehouseAddressState> SearchAll()
        {
            using var context = new AltoTestContext();
            try
            {
                return context.WarehouseAddressStates.ToList();

            }
            catch (Exception)
            {
                return new List<WarehouseAddressState>();
            }
        }
    }
}
