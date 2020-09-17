using Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms.ProductCategories;
using Alto_Valyrio.src.Inventory.Products.Applications.CreateCategory;
using Alto_Valyrio.src.Inventory.Products.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Alto_Valyrio.apps.Inventory.Frontend.src.Controller.Customer.CreateProducts
{
    public class CreateProductCategoriesController
    {
        public Form Show()
        {
            var repository = new SQLServerCategoryRepository();
            var producCreator = new ProductCategoryCreator(repository);
            var handler = new ProductCategoryCommandHandler(producCreator);

            var data = new Dictionary<string, object>
            {
                { "CreatorHandler", handler }
            };

            var form = new CreateProductCategory(data);
            return form;
        }
    }
}
