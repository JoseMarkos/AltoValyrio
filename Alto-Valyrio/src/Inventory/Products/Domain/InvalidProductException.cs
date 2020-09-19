using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Products.Domain
{
    public class InvalidProductException : Exception
    {
        public InvalidProductException(string name) : base($"{name} is not a product.")
        {
        }
    }
}
