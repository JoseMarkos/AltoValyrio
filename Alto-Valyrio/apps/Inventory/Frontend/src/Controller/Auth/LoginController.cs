using Alto_Valyrio.apps.Inventory.Backend;
using Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms;
using Alto_Valyrio.src.Inventory.Auth.Applications;
using Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Alto_Valyrio.apps.Inventory.Frontend.src.Controller.Auth
{
    public class LoginController : IController
    {
        private static Form login;

        private void SetData()
        {
            SQLServerAuthUserRepository repository = new SQLServerAuthUserRepository();
            UserAuthenticator authenticator = new UserAuthenticator(repository);
            AuthenticateUserCommandHandler handler =  new AuthenticateUserCommandHandler(authenticator);
            
            var data = new Dictionary<string, object>();
            data.Add("handler", handler);

            login = new Login(data);
        }

        public Form Show()
        {
            SetData();
            return login;
        }
    }
}
