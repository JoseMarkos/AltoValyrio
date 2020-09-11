using Alto_Valyrio.apps.Inventory.Backend;
using Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms.Warehouses;
using Alto_Valyrio.src.Inventory.Warehouses.Infrastructure.Persistance;
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

            var stateRepository = new SQLServerWarehouseStateRepository();
            var warehouseAddressStateRepository = new SQLServerWarehouseAddressStateRepository();
            var warehouseStates = stateRepository.SearchAll();
            var warehouseAddressStates = warehouseAddressStateRepository.SearchAll();
            var gtDepartments = new List<string>();
            var states = new List<string>();

            foreach (var item in warehouseAddressStates)
            {
                gtDepartments.Add(item.Name);
            }

            foreach (var item in warehouseStates)
            {
                states.Add(item.Name);
            }

            data.Add("warehousesAddressStates", gtDepartments);
            data.Add("warehousesStates", states);

            createWarehosue = new CreateWarehouse(data);
            return createWarehosue;
        }
    }
}
