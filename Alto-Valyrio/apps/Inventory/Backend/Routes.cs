using Alto_Valyrio.apps.Inventory.Frontend.src.Controller.Administrator.CreateUsers;
using Alto_Valyrio.apps.Inventory.Frontend.src.Controller.Auth;
using Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Alto_Valyrio.apps.Inventory.Backend
{
    class Routes
    {
        public static Dictionary<string, object> GetRoutes()
        {
            var dictionary = new Dictionary<string, object>();
            dictionary.Add("Login", new LoginController());
            dictionary.Add("CreateUser", new CreateUserController());

            return dictionary;
        }
    }
}
