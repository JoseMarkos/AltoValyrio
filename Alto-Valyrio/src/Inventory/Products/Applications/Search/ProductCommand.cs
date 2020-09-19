using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Products.Applications.Search
{
    public class ProductCommand
    {
        private readonly string Name;

        public ProductCommand(string name)
        {
            Name = name;
        }

        public string Name1 => Name;
    }
}
