﻿using Alto_Valyrio.src.Inventory.Users.Applications;
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
        readonly SQLServerRepository repository;
        readonly CreatorCommandHandler handler;
        readonly AdministratorCreator creator;

        public AdministratorCreatorTest()
        {
            repository = new SQLServerRepository();
            creator = new AdministratorCreator(repository);
            handler = new CreatorCommandHandler(creator);
        }

        [Fact]

        void Create()
        {
            var command = new CreatorCommand("Marcos", "hola");
            handler.Trigger(command);

            var list = repository.Matching("Marcos");
            Assert.Equal(1, list.Count);
        }
    }
}