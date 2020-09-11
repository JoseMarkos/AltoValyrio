using Alto_Valyrio.src.Inventory.Warehouses.Applications.Create;
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
            var telephone = int.Parse(txtTelephone.Text);

            try
            {
                Command = new WarehouseCommand(txtName.Text, GetState()
               , GetAddressState(), telephone, txtEmail.Text, txtDescription.Text);

                Handler.Trigger(Command);
            }
            catch (Exception warehouseCreateException)
            {


            }
           
        }

        private int GetState()
        {
            return comboState.SelectedIndex;
        }

        private int GetAddressState()
        {
            return comboGTDepartment.SelectedIndex;
        }
    }
}
