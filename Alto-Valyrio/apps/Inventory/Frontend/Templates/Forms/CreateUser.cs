using Alto_Valyrio.src.Inventory.Users.Applications;
using Alto_Valyrio.src.Inventory.Users.Domain;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveUser();

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            SaveUser();

            CleanInputs();
        }

        private void SaveUser ()
        {
            Command = new CreatorCommand(txtUsername.Text, txtPassword.Text
                                        , txtFirstName.Text, txtLastName.Text);

            try
            {
                Handler.Trigger(Command);
            }
            catch (UsernameAlreadyExistsException userAlreadyExists)
            {
                labelError.Text = userAlreadyExists.Message;
            }
        }

        private void CleanInputs ()
        {
            foreach (var item in tabAccountDetails.Controls)
            {
                bool isTextBox = item.GetType().ToString() == "System.Windows.Forms.TextBox";

                if (isTextBox)
                {
                    var txt = (TextBox)item;

                    txt.Text = String.Empty;
                }
            }
        }
    }
}
