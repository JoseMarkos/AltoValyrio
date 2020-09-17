using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Products.Applications.CreateCategory
{
    public class ProductCategoryCommand
    {
        private readonly string Name;

        public ProductCategoryCommand(string name)
        {
            Name = name;
        }

        public string GetName => Name;
    }
}
