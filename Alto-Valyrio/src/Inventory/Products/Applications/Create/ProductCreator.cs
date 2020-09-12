﻿using Alto_Valyrio.src.Inventory.Products.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Products.Applications.Create
{
    public class ProductCreator
    {
        private readonly IProductRepository Repository;

        public ProductCreator(IProductRepository repository)
        {
            Repository = repository;
        }

        public void Create(ProductName name, ProductBrand brand, ProductCategory category, ProductPacking packing, decimal price
            , bool refrigerated, DateTime expirationDate, int locationId, double weight, string description)
        {
            var product = new Product()
            {
                Name = name.GetValue(),
                Brand = brand.GetValue(),
                CategoryId = category.GetValue(),
                PackingTypeId = packing.GetValue(),
                Price = price,
                Refrigerated = refrigerated,
                ExpirationDate = expirationDate,
                LocationId = locationId,
                Weight = weight,
                Description = description
            };

            Repository.Save(product);
        }
    }
}
