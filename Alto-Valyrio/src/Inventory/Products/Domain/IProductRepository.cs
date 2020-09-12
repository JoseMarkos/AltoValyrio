using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Products.Domain
{
    public interface IProductRepository
    {
        void Save(Product product);

#nullable enable
        Product? Search(string name);
#nullable disable
    }
}
