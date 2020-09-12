using Alto_Valyrio.src.Shared.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Products.Domain
{
    public class ProductPacking : IntValueObject
    {
        public ProductPacking(int value) : base(value)
        {
            EnsureValuoIsNotEmpty(this.GetType().Name, value);

            this.value = value;
        }

        public void EnsureValuoIsNotEmpty(string fieldName, int value)
        {
            if (value == -1)
            {
                throw new EmptyFieldException(fieldName);
            }
        }
    }
}
