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
            var dashboard = new Dashboard();
            return dashboard;
        }
    }
}
