using Alto_Valyrio.src.Inventory.Auth.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Users.Applications
{
    public sealed class CreatorCommandHandler
    {
        private readonly ICreator Creator;

        public CreatorCommandHandler(ICreator creator)
        {
            Creator = creator;
        }

        public void Trigger(CreatorCommand command)
        {
            var username = new AuthUsername(command.GetUsername());
            var password = new AuthPassword(command.GetPassword());

            Creator.Create(username, password, command.GetFirstName(), command.GetLastName());
        }
    }
}
