using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Customers.Domain
{
    public interface ICustomerRepository
    {
        void Save(Customer customer);
        ICollection<Customer> SearchAll();
        ICollection<Customer> Matching(string criteria);
    }
}
