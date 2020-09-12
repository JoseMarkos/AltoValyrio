using Alto_Valyrio.apps.Inventory.Frontend.src.Controller.Administrator.CreateUsers;
using Alto_Valyrio.apps.Inventory.Frontend.src.Controller.Customer;
using Alto_Valyrio.apps.Inventory.Frontend.src.Controller.Auth;
using Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Alto_Valyrio.apps.Inventory.Frontend.src.Controller.Customer.CreateWarehouses;
using Alto_Valyrio.apps.Inventory.Frontend.src.Controller.Customer.CreateProducts;

namespace Alto_Valyrio.apps.Inventory.Backend
{
    class Routes
    {
        public static Dictionary<string, object> GetRoutes()
        {
            var dictionary = new Dictionary<string, object>
            {
                { "Login", new LoginController() },
                { "CreateUser", new CreateUserController() },
                { "CreateWarehouse", new CreateWarehousesController() },
                { "CreateProduct", new CreateProductsController() }
            };

            return dictionary;
        }
    }
}
