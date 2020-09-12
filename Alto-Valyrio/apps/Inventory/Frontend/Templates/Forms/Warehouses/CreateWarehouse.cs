using Alto_Valyrio.src.Inventory.Warehouses.Applications.Create;
using Alto_Valyrio.src.Inventory.Warehouses.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms.Warehouses
{
    public partial class CreateWarehouse : Form
    {
       // private CreatorCommand Command;
        private readonly List<string> GTDepartments;
        private readonly List<string> States;
        private readonly WarehouseCommandHandler Handler;
        private WarehouseCommand Command;

        public CreateWarehouse(Dictionary<string, object> data)
        {
            InitializeComponent();
            GTDepartments = (List<string>)data["warehousesAddressStates"];
            States = (List<string>)data["warehousesStates"];
            Handler = (WarehouseCommandHandler)data["handler"];

            PopulateGTDepartments();
            PopulateStates();
        }


        private void PopulateGTDepartments()
        {
            foreach (var item in GTDepartments)
            {
                comboGTDepartment.Items.Add(item);
            }
        }

        private void PopulateStates()
        {
            foreach (var item in States)
            {
               comboState.Items.Add(item);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var telephone = int.Parse(txtTelephone.Text);

                Command = new WarehouseCommand(txtName.Text, GetState()
               , GetAddressState(), txtAddress.Text,  telephone, txtEmail.Text, txtDescription.Text);

                Handler.Trigger(Command);

                this.Close();
            }
            catch (Exception warehouseCreateException)
            {
                labelError.Text = warehouseCreateException.Message;
            }
        }

        private int GetState()
        {
            int index = comboState.SelectedIndex;

            if (comboState.SelectedIndex == -1)
            {
                throw new InvalidWarehouseStateException();
            }

            index++;
            return index;
        }

        private int GetAddressState()
        {
            int index = comboGTDepartment.SelectedIndex;
            if (index == -1)
            {
                throw new InvalidWarehouseAddressStateException();
            }
            index++;
            return index;
        }

        private void BtnSaveAndNew_Click(object sender, EventArgs e)
        {
            try
            {
                var telephone = int.Parse(txtTelephone.Text);

                Command = new WarehouseCommand(txtName.Text, GetState()
               , GetAddressState(), txtAddress.Text, telephone, txtEmail.Text, txtDescription.Text);

                Handler.Trigger(Command);

                CleanInputs();
            }
            catch (Exception warehouseCreateException)
            {
                labelError.Text = warehouseCreateException.Message;
            }
        }

        private void CleanInputs()
        {
            foreach (var item in panel1.Controls)
            {
                bool isTextBox = item.GetType().ToString() == "System.Windows.Forms.TextBox";

                if (isTextBox)
                {
                    var txt = (TextBox)item;

                    txt.Text = String.Empty;
                }
            }

            labelError.Text = String.Empty;
        }
    }
}
