using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Warehouses.Domain
{
    public class InvalidWarehouseStateException : Exception
    {
        public InvalidWarehouseStateException() : base("Invalide warehouse state.")
        {
        }
    }
}
