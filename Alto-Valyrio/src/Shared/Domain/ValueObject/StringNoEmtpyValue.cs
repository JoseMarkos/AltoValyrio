using Alto_Valyrio.src.Inventory.Products.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Shared.Domain.ValueObject
{
    public abstract class StringNoEmtpyValue
    {
        public void EnsureValuoIsNotEmpty(string fieldName, string value)
        {
            if (value == String.Empty)
            {
                throw new EmptyFieldException(fieldName);
            }
        }
    }
}
