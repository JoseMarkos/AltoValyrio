using Alto_Valyrio.src.Inventory.Products.Applications.CreateCategory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms.ProductCategories
{
    public partial class CreateProductCategory : Form
    {
        private ProductCategoryCommand Command;
        private readonly ProductCategoryCommandHandler CreateHandler;

        public CreateProductCategory(Dictionary<string, object> data)
        {
            InitializeComponent();
            CreateHandler = (ProductCategoryCommandHandler)data["CreatorHandler"];
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Create();
                this.Close();
            }
            catch (Exception creteCategoryException)
            {
                labelError.Text = creteCategoryException.Message;
            }
        }

        private void Create ()
        {
            Command = new ProductCategoryCommand(textBox1.Text);
            CreateHandler.Trigger(Command);
        }
    }
}
