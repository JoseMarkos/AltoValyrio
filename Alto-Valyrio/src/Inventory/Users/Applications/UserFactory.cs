using Alto_Valyrio.src.Inventory.Users.Domain;
using Alto_Valyrio.src.Inventory.Users.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Users.Applications
{
    public sealed class UserFactory
    {
        public void Create(int role, CreatorCommand command)
        {
            SQLServerUsersRepository usersRepository = new SQLServerUsersRepository();
            AdministratorCreator administratorCreator = new AdministratorCreator(usersRepository);
            CustomerCreator customerCreator = new CustomerCreator(usersRepository);
            CreatorCommandHandler administratorHandler = new CreatorCommandHandler(administratorCreator);
            CreatorCommandHandler customerHandler = new CreatorCommandHandler(customerCreator);


            switch (role)
            {
                case (int)Roles.Administrator:
                    administratorHandler.Trigger(command);
                    break;

                case (int)Roles.Customer:
                    customerHandler.Trigger(command);
                    break;
                default:
                    throw new InvalidUserRoleException();
            }
        }
    }
}
