using Alto_Valyrio.apps.Inventory.Backend;
using Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms.Products;
using Alto_Valyrio.src.Inventory.Products.Applications.Create;
using Alto_Valyrio.src.Inventory.Products.Infrastructure.Persistance;
using Alto_Valyrio.src.Inventory.ProductsWarehouses.Applications.Create;
using Alto_Valyrio.src.Inventory.ProductsWarehouses.Infrastructure.Persistnace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alto_Valyrio.apps.Inventory.Frontend.src.Controller.Customer.CreateProducts
{
    public class CreateProductsController : IController
    {
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

            var createProductCategoryController = Routes.GetRoutes()["CreateProductCategory"];
            var productsWarehouseRepository = new SQLServerProductsWarehouseRepository();
            var productsWarehouseCreator = new ProductsWarehouseCreator(productsWarehouseRepository);
            var productsWarehouseCommandHandler = new ProductsWarehouseCommandHandler(productsWarehouseCreator);

            var data = new Dictionary<string, object>
            {
                { "createHandler", handler },
                { "categories", categories.ToList() },
                { "locations", locations.ToList() },
                { "packingTypes", packingTypes.ToList() },
                { "createProductCategoriesController", createProductCategoryController },
                { "productsWarehouseCreateHandler", productsWarehouseCommandHandler }
            };
            return new CreateProduct(data);
        }
    }
}
