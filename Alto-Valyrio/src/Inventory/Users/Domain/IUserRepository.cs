using Alto_Valyrio.src.Inventory.Users.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Users.Domain
{
    public interface IUserRepository
    {
        void Save(User customer);
        ICollection<User> SearchAll();
        ICollection<User> Matching(string criteria);
    }
}
