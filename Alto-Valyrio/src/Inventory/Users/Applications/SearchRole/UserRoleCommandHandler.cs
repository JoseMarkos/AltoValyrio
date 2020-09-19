using Alto_Valyrio.src.Inventory.Users.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Users.Applications.SearchRole
{
    public class UserRoleCommandHandler
    {
        private readonly UserRoleSearcher Searcher;

        public UserRoleCommandHandler(UserRoleSearcher searcher)
        {
            Searcher = searcher;
        }

        public Roles Trigger(UserRoleCommand command)
        {
            return Searcher.Search(command.Name1);
        }
    }
}
