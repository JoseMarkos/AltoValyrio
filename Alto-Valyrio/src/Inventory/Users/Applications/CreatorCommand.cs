using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Users.Applications
{
    public sealed class CreatorCommand
    {
        private readonly string Username;
        private readonly string Password;

        public CreatorCommand(string username, string password)
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
