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
            CustomerCreator customerCreator = new CustomerCreator(usersRepository);
            CreatorCommandHandler administratorHandler = new CreatorCommandHandler(administratorCreator);
            CreatorCommandHandler customerHandler = new CreatorCommandHandler(customerCreator);
            var userFactory = new UserFactory();

            SQLServerUserRolesRepository userRolesRepository = new SQLServerUserRolesRepository();
            var roles = userRolesRepository.SearchAll();
            var userRoles = new List<string>();

            foreach (var item in roles)
            {
                userRoles.Add(item.Name);
            }

            var data = new Dictionary<string, object>();
            data.Add("administratorHandler", administratorHandler);
            data.Add("customerHandler", customerHandler);
            data.Add("customerHandler", customerHandler);
            data.Add("factory", userFactory);
            data.Add("roles", userRoles);

            createUser = new CreateUser(data);
            return createUser;
        }
    }
}
