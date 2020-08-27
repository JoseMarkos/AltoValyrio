using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Auth.Domain
{
    public class InvalidAuthUsernameExeption : Exception
    {
        public InvalidAuthUsernameExeption(AuthUsername username) : base($"The user {username} does not exists")
        {
        }
    }
}
