﻿using Alto_Valyrio.src.Inventory.Products.Applications.Create;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Alto_Valyrio.src.Shared.apps.Frontend.Templates;
using Alto_Valyrio.src.Inventory.Products.Domain;
using Alto_Valyrio.apps.Inventory.Frontend.src.Packing;

namespace Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms.Products
{
    public partial class CreateProduct : Form
    {
        private ProductCommand Command;
        private readonly ProductCommandHandler CreateHandler;
        private readonly List<string> Categories;
        private readonly List<string> Locations;
        private readonly List<string> PackingTypes;
        private readonly int PackingSingleIndex = 1;

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
            decimal totalPrice = decimal.Parse(txtTotalPrice.Text);
            int amount = int.Parse(txtTotalAmount.Text);

            Command = new ProductCommand(txtName.Text, txtBrand.Text, GetCategoryId(), GetPackingTypeId(), price, GetRefrigeratedId(), dateExpiration.Value, GetLocationId(), weight, txtDescription.Text, totalPrice, amount);
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

            comboRefrigerated.SelectedIndex = 0;
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

            comboPackingType.SelectedIndex = PackingSingleIndex;
        }


        private void EnableAmountPackingField(object sender, EventArgs e)
        {
            int currentIndex = GetPackingTypeId();

            FieldsVisibilityHandler.Trigger(txtPackingAmount, PackingSingleIndex, currentIndex);
            MakeCalculation();
        }

        private void TotalPriceSingleCalculation(object sender, EventArgs e)
        {
            CalculateSinglePrice();  
        }

        private void CalculateSinglePrice()
        {
            try
            {
                int units = int.Parse(txtAmount.Text);

                if (txtPrice.Text != String.Empty)
                {
                    decimal pricePerUnit = decimal.Parse(txtPrice.Text);
                    txtTotalPrice.Text = TotalPriceCalculator.Calculate(units, pricePerUnit).ToString();
                }
            }
            catch (Exception priceValueException)
            {
                labelError.Text = priceValueException.Message;
            }
        }

        private void TotalPricePackingCalculation(object sender, EventArgs e)
        {
            CalculatePricePacking();
        }

        private void CalculatePricePacking()
        {
            try
            {
                if (txtPackingAmount.Text != String.Empty)
                {
                    int unitsPerPacking = int.Parse(txtPackingAmount.Text);
                    int unitsOfPacking = int.Parse(txtAmount.Text);
                    int units = unitsOfPacking * unitsPerPacking;

                    if (txtPrice.Text != String.Empty)
                    {
                        decimal pricePerUnit = decimal.Parse(txtPrice.Text);
                        txtTotalPrice.Text = TotalPriceCalculator.Calculate(units, pricePerUnit).ToString();
                    }
                }
            }
            catch (Exception priceValueException)
            {
                labelError.Text = priceValueException.Message;
            }
        }

        private void MakeCalculation()
        {
            if (PackingSingleIndex == comboPackingType.SelectedIndex)
            {
                CalculateSinglePrice();
                return;
            }

            CalculatePricePacking();
        }

        private void MakeCalculationEvent(object sender, EventArgs e)
        {
            MakeCalculation();
        }

        private void UpdateAmount(object sender, EventArgs e)
        {
            try
            {
                int singleAmount    = int.Parse(txtAmount.Text);
                int value           = singleAmount;

                if (txtPackingAmount.Text != String.Empty)
                {
                    value = int.Parse(txtPackingAmount.Text) * singleAmount;
                }

                txtTotalAmount.Text = value.ToString();
            }
            catch (Exception updateAmountException)
            {
                labelError.Text = updateAmountException.Message;
            }
        }
    }
}
