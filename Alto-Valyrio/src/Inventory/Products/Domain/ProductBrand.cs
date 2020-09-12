using Alto_Valyrio.src.Shared.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Products.Domain
{
    public class ProductBrand : StringValueObject
    {
        public ProductBrand(string value) : base(value)
        {
            EnsureValuoIsNotEmpty(this.GetType().Name, value);

            this.value = value;
        }

        public void EnsureValuoIsNotEmpty(string fieldName, string value)
        {
            if (value == String.Empty)
            {
                throw new EmptyFieldException(fieldName);
            }
        }
    }
}
