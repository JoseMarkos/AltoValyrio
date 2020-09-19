using Alto_Valyrio.src.Inventory.Products.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Products.Applications.Search
{
    public class ProductCommandHandler
    {
        private readonly ProductSearcher Searcher;

        public ProductCommandHandler(ProductSearcher searcher)
        {
            Searcher = searcher;
        }

        public Product Trigger(ProductCommand command)
        {
            return Searcher.Search(command.Name1);
        }
    }
}
