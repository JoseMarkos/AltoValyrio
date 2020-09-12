using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Products.Domain
{
    public class EmptyFieldException : Exception
    {
        public EmptyFieldException(string field) : base($"The {field} is empty.") 
        {
        }
    }
}
