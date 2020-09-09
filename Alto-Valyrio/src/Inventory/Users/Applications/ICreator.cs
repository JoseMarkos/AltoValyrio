using Alto_Valyrio.src.Inventory.Auth.Domain;
using Alto_Valyrio.src.Inventory.Users.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Users.Applications
{
    public interface ICreator
    {
        void Create(AuthUsername username
                , AuthPassword password, string firstName, string lastName);
    }
}
