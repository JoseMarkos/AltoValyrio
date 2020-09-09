using System.Collections.Generic;

namespace Alto_Valyrio.src.Inventory.Users.Domain
{
    public interface IUserRepository
    {
        void Save(User customer);
        ICollection<User> SearchAll();
        ICollection<User> Matching(string criteria);
    }
}
