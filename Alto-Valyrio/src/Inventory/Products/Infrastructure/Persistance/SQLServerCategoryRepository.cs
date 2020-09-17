using Alto_Valyrio.src.Inventory.Auth.Infrastructure.Persistance;
using Alto_Valyrio.src.Inventory.Products.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Products.Infrastructure.Persistance
{
    public class SQLServerCategoryRepository : IProductCategoryRepository
    {
        public void Save(Category category)
        {
            using var context = new AltoTestContext();

            context.ProductCategories.Add(category);
            context.SaveChanges();
        }

        public ICollection<Category> SearchAll()
        {
            using var context = new AltoTestContext();

            return context.ProductCategories.ToList();
        }
    }
}
