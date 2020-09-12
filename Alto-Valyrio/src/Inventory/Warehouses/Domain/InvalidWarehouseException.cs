using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Warehouses.Domain
{
    public class InvalidWarehouseException : Exception
    {
        public InvalidWarehouseException() : base("Warehouse exits already.")
        {
        }
    }
}
