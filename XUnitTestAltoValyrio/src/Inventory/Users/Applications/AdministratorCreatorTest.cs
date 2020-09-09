using Alto_Valyrio.src.Inventory.Users.Applications;
using Alto_Valyrio.src.Inventory.Users.Domain;
using Alto_Valyrio.src.Inventory.Users.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestAltoValyrio.src.Inventory.Users.Applications
{
    public class AdministratorCreatorTest
    {
        readonly SQLServerUsersRepository repository;
        readonly CreatorCommandHandler handler;
        readonly AdministratorCreator creator;

        public AdministratorCreatorTest()
        {
            repository = new SQLServerUsersRepository();
            creator = new AdministratorCreator(repository);
            handler = new CreatorCommandHandler(creator);
        }

        [Fact]

        void UserAlreadyExists()
        {
            var command = new CreatorCommand("Marcos", "holalola", "Marcos", "Bailon");

            Assert.Throws<UsernameAlreadyExistsException>(() => {
                handler.Trigger(command);
            });
        }
    }
}
