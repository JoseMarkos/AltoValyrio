using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Auth.Domain
{
    public sealed class InvalidAuthCredentialsException : Exception
    {
        public InvalidAuthCredentialsException(string username) : base($"The credentials for {username} are invalid")
        {

        }
    }
}
