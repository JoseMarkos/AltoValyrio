using Alto_Valyrio.src.Inventory.Users.Domain;
using Alto_Valyrio.src.Inventory.Purchases.Domain;
using System.Collections.Generic;

namespace Alto_Valyrio.src.Inventory.Users.Applications
{
    public class CustomerCreator
    {
        public static User Create() => new User
        {
            Purchases = new List<Purchase>(),
            Role = Roles.Customer
        };
    }
}
