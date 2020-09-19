using Alto_Valyrio.src.Inventory.Products.Domain;
using Alto_Valyrio.src.Inventory.Users.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Users.Applications.SearchRole
{
    public class UserRoleSearcher
    {
        private readonly IUserRepository repository;

        public UserRoleSearcher(IUserRepository repository)
        {
            this.repository = repository;
        }

        public Roles Search(string name)
        {
            var index = repository.Search(name).UserRoleId - 1;
            return (Roles)index;
        }
    }
}
