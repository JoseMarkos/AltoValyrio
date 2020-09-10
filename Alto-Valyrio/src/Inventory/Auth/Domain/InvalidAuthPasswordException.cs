using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Auth.Domain
{
    public class InvalidAuthPasswordException : Exception
    {
        public InvalidAuthPasswordException() : base("Please add a password.")
        {
        }
    }
}
