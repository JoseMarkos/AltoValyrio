using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Warehouses.Domain
{
    public interface IWarehouseStateRepository
    {
        ICollection<WarehouseState> SearchAll();
    }
}
