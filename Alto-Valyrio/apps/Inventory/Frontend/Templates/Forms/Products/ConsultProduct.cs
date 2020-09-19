using Alto_Valyrio.src.Inventory.Products.Applications.Search;
using Alto_Valyrio.src.Inventory.Products.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms.Products
{
    public partial class ConsultProduct : Form
    {
        private readonly ProductCommandHandler SearchHandler;
        public ConsultProduct(Dictionary<string, object> data)
        {
            InitializeComponent();
            SearchHandler = (ProductCommandHandler)data["searchHandler"];
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void Search()
        {
            try
            {
                var command = new ProductCommand(txtName.Text);
                var product = SearchHandler.Trigger(command);

                var list = new List<Product>
                {
                    product
                };

                var dataBinding = new BindingSource
                {
                    DataSource = list
                };

                dataGridView1.DataSource = dataBinding;
            }
            catch (InvalidProductException searchProductException)
            {
                labelError.Text = searchProductException.Message;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
