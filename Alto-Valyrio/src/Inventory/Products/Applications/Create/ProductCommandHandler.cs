using Alto_Valyrio.src.Inventory.Products.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Products.Applications.Create
{
    public class ProductCommandHandler
    {
        private readonly ProductCreator Creator;

        public ProductCommandHandler(ProductCreator creator)
        {
            Creator = creator;
        }

        public void Trigger(ProductCommand command)
        {
            var productName = new ProductName(command.GetName);
            var productCategory = new ProductCategory(command.GetCategoryId);
            var productBrand = new ProductBrand(command.GetBrand);
            var productPacking = new ProductPacking(command.GetPackingId);

            Creator.Create(productName, productBrand, productCategory, productPacking, command.GetPrice, command.GetRefrigerated
                , command.GetExpirationDate, command.GetLocationId, command.GetWeight, command.GetDescription);
        }
    }
}
