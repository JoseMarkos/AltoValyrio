using Alto_Valyrio.src.Inventory.Products.Domain;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Products.Applications.CreateCategory
{
    public class ProductCategoryCreator
    {
        private readonly IProductCategoryRepository Repository;

        public ProductCategoryCreator(IProductCategoryRepository repository)
        {
            Repository = repository;
        }

        public void Create(string name)
        {
            var category = new Category()
            {
                Name = name
            };

            Repository.Save(category);
        }
    }
}
