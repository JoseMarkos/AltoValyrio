using Alto_Valyrio.src.Inventory.Users.Applications;
using Alto_Valyrio.src.Inventory.Users.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms
{
    public partial class CreateUser : Form
    {
        private CreatorCommandHandler Handler;
        private CreatorCommand Command;

        public CreateUser(Dictionary<string, object> data)
        {
            InitializeComponent();
            Handler = (CreatorCommandHandler)data["handler"];
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Command = new CreatorCommand(txtUsername.Text, txtPassword.Text);
            Handler.Trigger(Command);
        }
    }
}
