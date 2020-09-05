using Alto_Valyrio.src.Inventory.Auth.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Auth.Applications
{
    public sealed class AuthenticateUserCommandHandler
    {
        private readonly UserAuthenticator Authenticator;

        public AuthenticateUserCommandHandler(UserAuthenticator authenticator)
        {
            Authenticator = authenticator;
        }

        public void Trigger(AuthenticateUserCommand command)
        {
            var username = new AuthUsername(command.GetUsername());
            var password = new AuthPassword(command.GetPassword());

            Authenticator.Authenticate(username, password);
        }
    }
}
