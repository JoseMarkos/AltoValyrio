using Alto_Valyrio.src.Inventory.Users.Applications;
using Alto_Valyrio.src.Inventory.Users.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms
{
    public partial class CreateUser : Form
    {
        private CreatorCommandHandler Handler;
        private CreatorCommand Command;
        private List<string> UserRoles;

        public CreateUser(Dictionary<string, object> data)
        {
            InitializeComponent();
            Handler = (CreatorCommandHandler)data["handler"];
            UserRoles = (List<string>)data["roles"];

            PopulateUserRoles();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Command = new CreatorCommand(txtUsername.Text, txtPassword.Text
                                       , txtFirstName.Text, txtLastName.Text);

            try
            {
                Handler.Trigger(Command);
                this.Close();
            }
            catch (UsernameAlreadyExistsException userAlreadyExists)
            {
                labelError.Text = userAlreadyExists.Message;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {

            Command = new CreatorCommand(txtUsername.Text, txtPassword.Text
                                       , txtFirstName.Text, txtLastName.Text);

            try
            {
                Handler.Trigger(Command);
                CleanInputs();
            }
            catch (UsernameAlreadyExistsException userAlreadyExists)
            {
                labelError.Text = userAlreadyExists.Message;
            }
        }


        private void CleanInputs()
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

        private void PopulateUserRoles()
        {
            foreach (var item in UserRoles)
            {
                comboRoles.Items.Add(item);
            }
        }
    }
}
