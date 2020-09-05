using Alto_Valyrio.src.Inventory.Customers.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Users.Applications
{
    public class AdministratorCreator
    {
        public static User Create() => new User
        {
            Purchases = null,
            Role = Roles.Administrator
        };
    }
}
