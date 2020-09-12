using Alto_Valyrio.src.Inventory.Products.Applications.Create;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Alto_Valyrio.src.Shared.apps.Frontend.Templates;
using Alto_Valyrio.src.Inventory.Products.Domain;

namespace Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms.Products
{
    public partial class CreateProduct : Form
    {
        private ProductCommand Command;
        private readonly ProductCommandHandler CreateHandler;
        private readonly List<string> Categories;
        private readonly List<string> Locations;
        private readonly List<string> PackingTypes;

        public CreateProduct(Dictionary<string, object> data)
        {
            InitializeComponent();
            CreateHandler = (ProductCommandHandler)data["createHandler"];
            Categories = (List<string>)data["categories"];
            Locations = (List<string>)data["locations"];
            PackingTypes = (List<string>)data["packingTypes"];

            PopulateComboRefrigerated();
            PopulateCategories();
            PopulateLocations();
            PopulatePackingTypes();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Create();

                this.Close();
            }
            catch (Exception createProductException)
            {
                labelError.Text = createProductException.Message;
            }
        }

        private void Create()
        {
            double weight = double.Parse(txtWeight.Text);
            decimal price = decimal.Parse(txtPrice.Text);

            Command = new ProductCommand(txtName.Text, txtBrand.Text, GetCategoryId(), GetPackingTypeId(), price, GetRefrigeratedId(), dateExpiration.Value, GetLocationId(), weight, txtDescription.Text);
            CreateHandler.Trigger(Command);
        }


        private int GetCategoryId()
        {
            return comboCategory.SelectedIndex;
        }

        private int GetPackingTypeId()
        {
            return comboPackingType.SelectedIndex;
        }

        private int GetLocationId()
        {
            return comboLocation.SelectedIndex;
        }

        private void PopulateComboRefrigerated()
        {
            comboRefrigerated.Items.Add("No");
            comboRefrigerated.Items.Add("Yes");
        }

        private bool GetRefrigeratedId()
        {
            bool index = false;
            if (comboRefrigerated.SelectedIndex == 1)
            {
                index = true;
            }

            return index;
        }

        private void BtnSaveAndNew_Click(object sender, EventArgs e)
        {
            try
            {
                Create();

                CleanInputs();
            }
            catch (Exception createProductException)
            {
                labelError.Text = createProductException.Message;
            }
        }

        private void CleanInputs()
        {
            Utils.CleanTextBoxInputs(panel1);
            Utils.CleanNotificationLabel(labelError);
            Utils.CleanComboBoxInputs(panel1);
        }

        private void PopulateCategories()
        {
            foreach (var item in Categories)
            {
                comboCategory.Items.Add(item);
            }
        }

        private void PopulateLocations()
        {
            foreach (var item in Locations)
            {
                comboLocation.Items.Add(item);
            }
        }

        private void PopulatePackingTypes()
        {
            foreach (var item in PackingTypes)
            {
                comboPackingType.Items.Add(item);
            }

            //comboPackingType.SelectedIndex = 1;
        }
    }
}
