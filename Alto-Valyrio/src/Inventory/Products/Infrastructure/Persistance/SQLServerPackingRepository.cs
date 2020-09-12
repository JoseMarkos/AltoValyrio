using Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance;
using Alto_Valyrio.src.Inventory.Products.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Products.Infrastructure.Persistance
{
    public class SQLServerPackingRepository
    {
        public ICollection<Packing> SearchAll()
        {
            using var context = new AltoTestContext();

            return context.ProductPackingTypes.ToList();
        }
    }
}
