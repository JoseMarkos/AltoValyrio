using Alto_Valyrio.apps.Inventory.Backend;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms;
using Alto_Valyrio.src.Inventory.Users.Applications;
using Alto_Valyrio.src.Inventory.Users.Infrastructure.Persistance;

namespace Alto_Valyrio.apps.Inventory.Frontend.src.Controller.Administrator.CreateUsers
{
    public class CreateUserController : IController
    {
        private static Form createUser;



        public Form Show()
        {
            SQLServerUsersRepository usersRepository = new SQLServerUsersRepository();
            AdministratorCreator administratorCreator = new AdministratorCreator(usersRepository);
            CreatorCommandHandler handler = new CreatorCommandHandler(administratorCreator);

            SQLServerUserRolesRepository userRolesRepository = new SQLServerUserRolesRepository();
            var roles = userRolesRepository.SearchAll();
            var userRoles = new List<string>();

            foreach (var item in roles)
            {
                userRoles.Add(item.Name);
            }

            var data = new Dictionary<string, object>();
            data.Add("handler", handler);
            data.Add("roles", userRoles);

            createUser = new CreateUser(data);
            return createUser;
        }
    }
}
