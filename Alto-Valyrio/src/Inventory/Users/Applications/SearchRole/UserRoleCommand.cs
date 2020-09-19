using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Users.Applications.SearchRole
{
    public class UserRoleCommand
    {
        private readonly string Name;

        public UserRoleCommand(string name)
        {
            Name = name;
        }

        public string Name1 => Name;
    }
}
