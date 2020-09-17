using System;
using System.Collections.Generic;
using System.Text;

namespace Alto_Valyrio.src.Inventory.Products.Domain
{
    public interface IProductCategoryRepository
    {
        ICollection<Category> SearchAll();
        void Save(Category category);
    }
}
