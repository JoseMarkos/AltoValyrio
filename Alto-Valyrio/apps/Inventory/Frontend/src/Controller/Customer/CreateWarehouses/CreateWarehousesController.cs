using Alto_Valyrio.apps.Inventory.Backend;
using Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms.Warehouses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Alto_Valyrio.apps.Inventory.Frontend.src.Controller.Customer.CreateWarehouses
{
    public class CreateWarehousesController : IController
    {
        private static Form createWarehosue;

        public Form Show()
        {
            var data = new Dictionary<string, object>();

            createWarehosue = new CreateWarehouse(data);
            return createWarehosue;
        }
    }
}
