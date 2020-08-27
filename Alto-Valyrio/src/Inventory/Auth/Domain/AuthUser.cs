using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Auth.Domain
{
    public sealed class AuthUser
    {
        private readonly AuthUsername Username;
        private readonly AuthPassword Password;

        public AuthUser(AuthUsername username, AuthPassword password)
        {
            this.Username = username;
            this.Password = password;
        }

        public bool PasswordMatches(AuthPassword password)
        {
            return Password.IsEquals(password);
        }

        public AuthUsername GetUserName()
        {
            return Username;
        }
    }
}
