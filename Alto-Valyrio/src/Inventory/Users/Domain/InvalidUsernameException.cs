using Alto_Valyrio.src.Inventory.Auth.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Users.Domain
{
    public class InvalidUsernameException : Exception
    {
        public InvalidUsernameException(string username) : base ($"The user {username} is not available")
        {
        }
    }
}
