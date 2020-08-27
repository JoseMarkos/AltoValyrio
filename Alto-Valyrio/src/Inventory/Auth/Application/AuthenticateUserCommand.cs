using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Auth.Application
{
    public sealed class AuthenticateUserCommand
    {

        private string Username;
        private string Password;

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
