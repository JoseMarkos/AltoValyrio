using Alto_Valyrio.src.Inventory.Users.Applications;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms
{
    public partial class CreateUser : Form
    {
        private CreatorCommand Command;
        private readonly List<string> UserRoles;
        private readonly UserFactory UserFactory;

        public CreateUser(Dictionary<string, object> data)
        {
            InitializeComponent();
            UserRoles = (List<string>)data["roles"];
            UserFactory = (UserFactory)data["factory"];

            PopulateUserRoles();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Command = new CreatorCommand(txtUsername.Text, txtPassword.Text
                                       , txtFirstName.Text, txtLastName.Text);

            try
            {
                Create();

                this.Close();
            }
            catch (Exception saveUserException)
            {
                // Generic because it could be invalid user name or invalid user role
                labelError.Text = saveUserException.Message;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSaveAndNew_Click(object sender, EventArgs e)
        {

            Command = new CreatorCommand(txtUsername.Text, txtPassword.Text
                                       , txtFirstName.Text, txtLastName.Text);

            try
            {
                Create();

                CleanInputs();
            }
            catch (Exception saveAndNewUserException)
            {
                labelError.Text = saveAndNewUserException.Message;
            }
        }

        private void Create()
        {
            UserFactory.Create(GetUserRole(), Command);
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

            labelError.Text = String.Empty;
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

        private void Administrator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
