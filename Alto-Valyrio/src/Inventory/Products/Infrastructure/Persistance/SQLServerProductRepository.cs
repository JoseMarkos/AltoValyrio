using Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance;
using Alto_Valyrio.src.Inventory.Products.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Products.Infrastructure.Persistance
{
    public class SQLServerProductRepository : IProductRepository
    {
        public void Save(Product product)
        {
            using var context = new AltoTestContext();

            context.Products.Add(product);
            context.SaveChanges();
        }

        public Product Search(string name)
        {
            using var context = new AltoTestContext();

            return  context.Products
                       .Where(b => b.Name == name)
                       .FirstOrDefault();
        }
    }
}
