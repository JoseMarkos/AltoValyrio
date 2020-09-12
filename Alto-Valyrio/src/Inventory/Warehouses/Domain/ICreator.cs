using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Warehouses.Domain
{
    public interface ICreator
    {
        void Create(string name, int stateId, int addressStateId, string address, int telephone, string email, string description);
    }
}
