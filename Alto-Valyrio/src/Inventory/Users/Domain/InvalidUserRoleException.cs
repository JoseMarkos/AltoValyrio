using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Users.Domain
{
    public class InvalidUserRoleException : Exception
    {
        public InvalidUserRoleException() : base("Inavlide user role")
        {
        }
    }
}
