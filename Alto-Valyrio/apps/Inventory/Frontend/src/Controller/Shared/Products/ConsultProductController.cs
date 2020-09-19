using Alto_Valyrio.apps.Inventory.Backend;
using Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms.Products;
using Alto_Valyrio.src.Inventory.Products.Applications.Search;
using Alto_Valyrio.src.Inventory.Products.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Alto_Valyrio.apps.Inventory.Frontend.src.Controller.Shared.Products
{
    public class ConsultProductController : IController
    {
        public Form Show()
        {
            var repository = new SQLServerProductRepository();
            var searcher = new ProductSearcher(repository);
            var handler = new ProductCommandHandler(searcher);
            var data = new Dictionary<string, object>
            {
                { "searchHandler", handler },
            };
            var form = new ConsultProduct(data);
            return form;
        }
    }
}
