using Alto_Valyrio.src.Inventory.Products.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Products.Applications.Search
{
    public class ProductSearcher
    {
        private readonly IProductRepository Repository;

        public ProductSearcher(IProductRepository repository)
        {
            Repository = repository;
        }

        public Product Search(string name)
        {
            var match = Repository.Search(name);
            EnsureProductExist(match, name);

            return match;
        }

#nullable enable
        private void EnsureProductExist(Product? product, string name)
        {
            if (product is null)
            {
                throw new InvalidProductException(name);
            }
        }
#nullable disable
    }
}
