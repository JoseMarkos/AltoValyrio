using Alto_Valyrio.apps.Inventory.Backend;
using Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms.Products;
using Alto_Valyrio.src.Inventory.Products.Applications.Create;
using Alto_Valyrio.src.Inventory.Products.Domain;
using Alto_Valyrio.src.Inventory.Products.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alto_Valyrio.apps.Inventory.Frontend.src.Controller.Customer.CreateProducts
{
    public class EditProduct: CreateProduct
    {
        public EditProduct(Dictionary<string, object> data) : base(data)
        {

        }
    }
}
