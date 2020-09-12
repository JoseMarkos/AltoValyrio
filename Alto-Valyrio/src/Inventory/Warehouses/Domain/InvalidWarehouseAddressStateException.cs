using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Warehouses.Domain
{
    public class InvalidWarehouseAddressStateException : Exception
    {
        public InvalidWarehouseAddressStateException() : base("Invalid GT Department.")
        {
        }
    }
}
