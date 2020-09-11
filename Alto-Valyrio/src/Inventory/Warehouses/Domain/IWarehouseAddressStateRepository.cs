using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Warehouses.Domain
{
    public interface IWarehouseAddressStateRepository
    {
        ICollection<WarehouseAddressState> SearchAll();
    }
}
