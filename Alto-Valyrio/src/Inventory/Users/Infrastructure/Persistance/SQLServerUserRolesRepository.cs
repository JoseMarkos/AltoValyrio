using Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance;
using Alto_Valyrio.src.Inventory.Users.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Users.Infrastructure.Persistance
{
    class SQLServerUserRolesRepository : IUserRoleRepository
    {
        public ICollection<UserRole> SearchAll()
        {
            using var context = new AltoTestContext();
            try
            {
                return context.UserRoles.ToList();
            }
            catch (Exception)
            {
                return new List<UserRole>();
            }
        }
    }
}
