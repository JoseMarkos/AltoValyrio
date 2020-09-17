using Alto_Valyrio.src.Shared.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Products.Domain
{
    public class ProductCategory : IntValueObject
    {
        public ProductCategory(int value) : base(value)
        {
            EnsureIsNotEmpty(this.GetType().Name, value);

            this.value = value + 1;
        }

        public void EnsureIsNotEmpty(string fieldName, int value)
        {
            if (value == -1)
            {
                throw new EmptyFieldException(fieldName);
            }
        }
    }
}
