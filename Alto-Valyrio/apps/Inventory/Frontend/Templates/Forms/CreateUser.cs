using Alto_Valyrio.src.Inventory.Users.Applications;
using Alto_Valyrio.src.Inventory.Users.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms
{
    public partial class CreateUser : Form
    {
        private CreatorCommandHandler AdministratorHandler;
        private CreatorCommandHandler CustomerHandler;
        private CreatorCommand Command;
        private List<string> UserRoles;

        public CreateUser(Dictionary<string, object> data)
        {
            InitializeComponent();
            AdministratorHandler = (CreatorCommandHandler)data["administratorHandler"];
            CustomerHandler = (CreatorCommandHandler)data["customerHandler"];
            UserRoles = (List<string>)data["roles"];

            PopulateUserRoles();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Command = new CreatorCommand(txtUsername.Text, txtPassword.Text
                                       , txtFirstName.Text, txtLastName.Text);

            try
            {
                AdministratorHandler.Trigger(Command);
                this.Close();
            }
            catch (InvalidUsernameException userAlreadyExists)
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
                AdministratorHandler.Trigger(Command);
                CleanInputs();
            }
            catch (InvalidUsernameException userAlreadyExists)
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

        private int GetUserRole()
        {
            return comboRoles.SelectedIndex;
        }
    }
}
