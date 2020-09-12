using Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance;
using Alto_Valyrio.src.Inventory.Products.Domain;
using Alto_Valyrio.src.Inventory.Warehouses.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Products.Infrastructure.Persistance
{
    public class SQLServerLocationRepository
    {
        public ICollection<Warehouse> SearchAll()
        {
            using var context = new AltoTestContext();

            return context.Warehouses.ToList();
        }
    }
}
