using Alto_Valyrio.apps.Inventory.Backend;
using Alto_Valyrio.src.Inventory.Auth.Applications;
using Alto_Valyrio.src.Inventory.Users.Applications.SearchRole;
using Alto_Valyrio.src.Inventory.Users.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms
{
    public partial class Login : Form
    {
        private readonly AuthenticateUserCommandHandler Handler;
        private AuthenticateUserCommand Command;
        private readonly Dictionary<Roles, IController> Dashboards;
        private readonly UserRoleCommandHandler UserRoleCommandHandler;

        public Login(Dictionary<string, object> data)
        {
            InitializeComponent();

            Handler = (AuthenticateUserCommandHandler)data["handler"];
            UserRoleCommandHandler = (UserRoleCommandHandler)data["userRoleCommandHandler"];
            Dashboards = (Dictionary<Roles, IController>)data["dashboards"];
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Command = new AuthenticateUserCommand(txtUsername.Text, txtPassword.Text);
                Handler.Trigger(Command);

                var command = new UserRoleCommand(txtUsername.Text);
                var role = UserRoleCommandHandler.Trigger(command);
                var controller = Dashboards[role];
                var form = controller.Show();

                form.Show();
                this.Hide();
            }
            catch (Exception AuthExeption)
            {
                labelError.Text = AuthExeption.Message;
            }
        }

        protected void Exit(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
