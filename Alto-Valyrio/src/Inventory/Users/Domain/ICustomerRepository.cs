using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Users.Domain
{
    public interface ICustomerRepository
    {
        void Save(User customer);
        ICollection<User> SearchAll();
        ICollection<User> Matching(string criteria);
    }
}
