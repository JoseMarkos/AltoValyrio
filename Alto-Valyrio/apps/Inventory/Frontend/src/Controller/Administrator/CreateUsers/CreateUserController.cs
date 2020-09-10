using Alto_Valyrio.apps.Inventory.Backend;
using Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms;
using Alto_Valyrio.src.Inventory.Users.Applications;
using Alto_Valyrio.src.Inventory.Users.Infrastructure.Persistance;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Alto_Valyrio.apps.Inventory.Frontend.src.Controller.Administrator.CreateUsers
{
    public class CreateUserController : IController
    {
        private static Form createUser;

        public Form Show()
        {
            SQLServerUsersRepository usersRepository = new SQLServerUsersRepository();
            var userFactory = new UserFactory();

            SQLServerUserRolesRepository userRolesRepository = new SQLServerUserRolesRepository();
            var roles = userRolesRepository.SearchAll();
            var userRoles = new List<string>();

            foreach (var item in roles)
            {
                userRoles.Add(item.Name);
            }

            var data = new Dictionary<string, object>();
            data.Add("factory", userFactory);
            data.Add("roles", userRoles);

            createUser = new CreateUser(data);
            return createUser;
        }
    }
}
