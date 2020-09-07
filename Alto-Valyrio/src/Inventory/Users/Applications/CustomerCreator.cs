using Alto_Valyrio.src.Inventory.Users.Domain;
using Alto_Valyrio.src.Inventory.Purchases.Domain;
using System.Collections.Generic;
using Alto_Valyrio.src.Inventory.Auth.Domain;

namespace Alto_Valyrio.src.Inventory.Users.Applications
{
    public class CustomerCreator : ICreator
    {
        private readonly IUserRepository Repository;

        public CustomerCreator(IUserRepository repository)
        {
            Repository = repository;
        }

        public void Create(AuthUsername username, AuthPassword password)
        {
            User user = new User
            {
                Purchases = new List<Purchase>(),
                Role = Roles.Customer,
                Username = username.GetValue(),
                Password = username.GetValue()
            };

            Repository.Save(user);
        }
    }
}
