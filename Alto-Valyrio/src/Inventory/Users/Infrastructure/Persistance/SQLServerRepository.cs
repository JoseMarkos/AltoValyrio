using Alto_Valyrio.src.Inventory.Customers.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Customers.Infrastructure.Persistance
{
    public sealed class SQLServerRepository : ICustomerRepository
    {
        public ICollection<User> Matching(string criteria)
        {
            throw new NotImplementedException();
        }

        public void Save(User customer)
        {
            throw new NotImplementedException();
        }

        public ICollection<User> SearchAll()
        {
            throw new NotImplementedException();
        }
    }
}
