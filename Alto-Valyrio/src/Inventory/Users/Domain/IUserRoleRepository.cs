using Alto_Valyrio.src.Inventory.Users.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Users.Domain
{
    public interface IUserRoleRepository
    {
        ICollection<UserRole> SearchAll();
    }
}
