using Alto_Valyrio.apps.Inventory.Backend;
using Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms.Products;
using Alto_Valyrio.src.Inventory.Products.Applications.Create;
using Alto_Valyrio.src.Inventory.Products.Domain;
using Alto_Valyrio.src.Inventory.Products.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alto_Valyrio.apps.Inventory.Frontend.src.Controller.Customer.CreateProducts
{
    public class EditProductController : IController
    {
        private readonly Product Product;

        public EditProductController(Product product)
        {
            Product = product;
        }

        public Form Show()
        {
            var repository = new SQLServerProductRepository();
            var producCreator = new ProductCreator(repository);
            var handler = new ProductCommandHandler(producCreator);
            var categoriesEntities = new SQLServerCategoryRepository().SearchAll().ToList();
            var locationsEntities = new SQLServerLocationRepository().SearchAll().ToList();
            var packingTypesEntities = new SQLServerPackingRepository().SearchAll().ToList();

            var categories = from x in categoriesEntities
                             select x.Name;

            var locations = from x in locationsEntities
                            select x.Name;

            var packingTypes = from x in packingTypesEntities
                               select x.Name;

            var data = new Dictionary<string, object>
            {
                { "createHandler", handler },
                { "categories", categories.ToList() },
                { "locations", locations.ToList() },
                { "packingTypes", packingTypes.ToList() },
                { "product", Product }
            };
            return new EditProduct(data);
        }
    }
}
