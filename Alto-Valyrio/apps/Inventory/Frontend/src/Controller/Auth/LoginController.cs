using Alto_Valyrio.apps.Inventory.Backend;
using Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms;
using Alto_Valyrio.src.Inventory.Auth.Applications;
using Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance;
using Alto_Valyrio.src.Inventory.Users.Applications.SearchRole;
using Alto_Valyrio.src.Inventory.Users.Domain;
using Alto_Valyrio.src.Inventory.Users.Infrastructure.Persistance;
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
            var dashboards = new Dictionary<Roles, IController> {
                { Roles.Administrator, (IController)Routes.GetRoutes()["CreateUser"] },
                { Roles.Customer, (IController)Routes.GetRoutes()["CustomerDashboard"] }
            };

            var userRepository = new SQLServerUsersRepository();
            var userRoleSearcher = new UserRoleSearcher(userRepository);
            var userRoleCommandHandler = new UserRoleCommandHandler(userRoleSearcher);

            var data = new Dictionary<string, object>
            {
                { "handler", handler },
                { "dashboards", dashboards },
                { "userRoleCommandHandler", userRoleCommandHandler }
            };

            login = new Login(data);
        }

        public Form Show()
        {
            SetData();
            return login;
        }
    }
}
