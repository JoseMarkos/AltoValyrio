using Alto_Valyrio.src.Inventory.Auth.Applications;
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
        private AuthenticateUserCommandHandler Handler;
        private AuthenticateUserCommand Command;
        public Login(Dictionary<string, object> data)
        {
            InitializeComponent();

            Handler = (AuthenticateUserCommandHandler)data["handler"];
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Command = new AuthenticateUserCommand(txtUsername.Text, txtPassword.Text);
                Handler.Trigger(Command);
            }
            catch (Exception AuthExeption)
            {
                labelError.Text = AuthExeption.Message;
            }
        }
    }
}
