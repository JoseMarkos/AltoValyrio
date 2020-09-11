using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Warehouses.Domain
{
    public interface IWarehouseRepository
    {
        void Save(Warehouse warehouse);

#nullable enable
        Warehouse? Search(int id);
#nullable disable
    }
}
