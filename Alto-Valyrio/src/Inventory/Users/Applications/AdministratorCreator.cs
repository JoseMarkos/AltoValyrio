using Alto_Valyrio.src.Inventory.Auth.Domain;
using Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance;
using Alto_Valyrio.src.Inventory.Users.Domain;
using Alto_Valyrio.src.Inventory.Users.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Users.Applications
{
    public sealed class AdministratorCreator : ICreator
    {

        private readonly IUserRepository Repository;

        public AdministratorCreator(IUserRepository repository)
        {
            Repository = repository;
        }

        public void Create(AuthUsername username, AuthPassword password
                            , string firtName, string lastName)
        {
            EnsureUsernameNotExists(username);
            
            var user = new User
            {
                Purchases = null,
                Role = Roles.Administrator,
                Username = username.GetValue(),
                Password = password.GetValue(),
                FirstName =  firtName,
                LastName =  lastName
            };

            Repository.Save(user);
        }

        private void EnsureUsernameNotExists(AuthUsername username)
        {
            var authRepository = new SQLServerAuthUserRepository();
            var match = authRepository.Search(username);

            if (!(match is null))
            {
                throw new InvalidUsernameException(username.GetValue());
            }
        }
    }
}
