﻿using Alto_Valyrio.src.Inventory.Users.Domain;
using Alto_Valyrio.src.Inventory.Purchases.Domain;
using System.Collections.Generic;
using Alto_Valyrio.src.Inventory.Auth.Domain;
using Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance;

namespace Alto_Valyrio.src.Inventory.Users.Applications
{
    public class CustomerCreator : ICreator
    {
        private readonly IUserRepository Repository;

        public CustomerCreator(IUserRepository repository)
        {
            Repository = repository;
        }

        public void Create(AuthUsername username, AuthPassword password
                            , string firtName, string lastName)
        {
            EnsureUsernameNotExists(username);

            User user = new User
            {
                Purchases = new List<Purchase>(),
                Role = Roles.Customer,
                Username = username.GetValue(),
                Password = username.GetValue(),
                FirstName = firtName,
                LastName = lastName
            };

            Repository.Save(user);
        }

        private void EnsureUsernameNotExists(AuthUsername username)
        {
            var authRepository = new SQLServerAuthUserRepository();
            var match = authRepository.Search(username);

            if (!(match is null))
            {
                throw new UsernameAlreadyExistsException(username.GetValue());
            }
        }
    }
}
