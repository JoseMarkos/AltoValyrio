using Alto_Valyrio.apps.Inventory.Backend;
using Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms.Customer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Alto_Valyrio.apps.Inventory.Frontend.src.Controller.Customer.Main
{
    public class DashboardController : IController
    {
        public Form Show()
        {
            var routes = Routes.GetRoutes();

            var menuItems = new Dictionary<string, IController>
            {
                { "Add a register", (IController)routes["CreateProduct"] },
                { "Consult a register", (IController)routes["ConsultProduct"] },
                { "Move a register", (IController)routes["CreateProduct"] },
            };



            var data = new Dictionary<string, object>
            {
                { "menuItems", menuItems },
                { "login", (IController)routes["Login"] }
            };

            var dashboard = new Dashboard(data);
            return dashboard;
        }
    }
}
