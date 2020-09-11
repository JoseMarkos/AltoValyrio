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

        public CreateWarehouse(Dictionary<string, object> data)
        {
            InitializeComponent();
            GTDepartments = (List<string>)data["warehousesAddressStates"];
            States = (List<string>)data["warehousesStates"];


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

        }
    }
}
