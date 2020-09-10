﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Auth.Domain
{
    public class EmptyAuthUsernameException : Exception
    {
        public EmptyAuthUsernameException(string? message) : base((message is null) ? "Please add an username." : message)
        {
        }
    }
}