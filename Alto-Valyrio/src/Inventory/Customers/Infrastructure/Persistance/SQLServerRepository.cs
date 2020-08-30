using Alto_Valyrio.src.Inventory.Customers.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Customers.Infrastructure.Persistance
{
    public sealed class SQLServerRepository : ICustomerRepository
    {
        public ICollection<Customer> Matching(string criteria)
        {
            throw new NotImplementedException();
        }

        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }

        public ICollection<Customer> SearchAll()
        {
            throw new NotImplementedException();
        }
    }
}
