using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.ProductsWarehouses.Applications.Create
{
    public class ProductsWarehouseCommandHandler
    {
        private readonly ProductsWarehouseCreator Creator;

        public ProductsWarehouseCommandHandler(ProductsWarehouseCreator creator)
        {
            Creator = creator;
        }

        public void Trigger(ProductsWarehouseCommand command)
        {
            Creator.Create(command.GetProductId, command.GetWarehouseId);
        }
    }
}
