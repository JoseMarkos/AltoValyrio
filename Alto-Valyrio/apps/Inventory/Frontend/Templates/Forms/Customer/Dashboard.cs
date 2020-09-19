using Alto_Valyrio.apps.Inventory.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms.Customer
{
    public partial class Dashboard : Form
    {
        private readonly Dictionary<string, IController> MenuItems;

        public Dashboard(Dictionary<string, object> data)
        {
            MenuItems = (Dictionary<string, IController>)data["menuItems"];

            InitializeComponent();
            PopulateRegistrosMenu();
        }

        private void PopulateRegistrosMenu ()
        {
            PopulateComboRegistros();
        }

        private void PopulateComboRegistros()
        {
            var itemNames = from item in MenuItems
                            select item.Key;

            foreach (var item in itemNames)
            {
                comboRegistros.Items.Add(item);
            }
        }

        private void ComboRegistros_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenFormDialog(comboRegistros.SelectedItem.ToString());
        }

        private void OpenFormDialog(string key)
        {
            var controller  = MenuItems[key];
            var form        = controller.Show();

            form.ShowDialog();
        }
    }
}
