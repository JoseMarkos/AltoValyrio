using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Auth.Applications
{
    public sealed class AuthenticateUserCommand
    {

        private readonly string Username;
        private readonly string Password;

        public AuthenticateUserCommand(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string GetUsername()
        {
            return this.Username;
        }

        public string GetPassword()
        {
            return this.Password;
        }
    }
}
