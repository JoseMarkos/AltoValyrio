using Alto_Valyrio.src.Inventory.Auth.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Users.Domain
{
    public class UsernameAlreadyExistsException : Exception
    {
        public UsernameAlreadyExistsException(string username) : base ($"The user {username} is not available")
        {
        }
    }
}
