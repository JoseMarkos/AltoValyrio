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
        }
    }
}
