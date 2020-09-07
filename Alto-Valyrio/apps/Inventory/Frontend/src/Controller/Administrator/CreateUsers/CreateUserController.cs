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
            SQLServerRepository repository = new SQLServerRepository();
            AdministratorCreator administratorCreator = new AdministratorCreator(repository);
            CreatorCommandHandler handler = new CreatorCommandHandler(administratorCreator);

            var data = new Dictionary<string, object>();
            data.Add("handler", handler);

            createUser = new CreateUser(data);
            return createUser;
        }
    }
}
