namespace Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms
{
    partial class CreateUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAccountDetails = new System.Windows.Forms.TabPage();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.tabAssignedUserRole = new System.Windows.Forms.TabPage();
            this.comboRoles = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabAccountDetails.SuspendLayout();
            this.tabAssignedUserRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.labelError);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 497);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(354, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save and new";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(240, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 38);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelError
            // 
            this.labelError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelError.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelError.ForeColor = System.Drawing.Color.Maroon;
            this.labelError.Location = new System.Drawing.Point(37, 444);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(466, 40);
            this.labelError.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAccountDetails);
            this.tabControl1.Controls.Add(this.tabAssignedUserRole);
            this.tabControl1.Location = new System.Drawing.Point(37, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 2;
            this.tabControl1.Size = new System.Drawing.Size(470, 359);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabAccountDetails
            // 
            this.tabAccountDetails.Controls.Add(this.txtLastName);
            this.tabAccountDetails.Controls.Add(this.label4);
            this.tabAccountDetails.Controls.Add(this.txtFirstName);
            this.tabAccountDetails.Controls.Add(this.label3);
            this.tabAccountDetails.Controls.Add(this.label2);
            this.tabAccountDetails.Controls.Add(this.label1);
            this.tabAccountDetails.Controls.Add(this.txtPassword);
            this.tabAccountDetails.Controls.Add(this.txtUsername);
            this.tabAccountDetails.Location = new System.Drawing.Point(4, 34);
            this.tabAccountDetails.Name = "tabAccountDetails";
            this.tabAccountDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccountDetails.Size = new System.Drawing.Size(462, 321);
            this.tabAccountDetails.TabIndex = 0;
            this.tabAccountDetails.Text = "Account Details";
            this.tabAccountDetails.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(267, 51);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(176, 33);
            this.txtLastName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(267, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(20, 229);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(176, 33);
            this.txtFirstName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(20, 137);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(176, 33);
            this.txtPassword.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(20, 51);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(176, 33);
            this.txtUsername.TabIndex = 0;
            // 
            // tabAssignedUserRole
            // 
            this.tabAssignedUserRole.Controls.Add(this.comboRoles);
            this.tabAssignedUserRole.Location = new System.Drawing.Point(4, 34);
            this.tabAssignedUserRole.Name = "tabAssignedUserRole";
            this.tabAssignedUserRole.Padding = new System.Windows.Forms.Padding(3);
            this.tabAssignedUserRole.Size = new System.Drawing.Size(462, 321);
            this.tabAssignedUserRole.TabIndex = 1;
            this.tabAssignedUserRole.Text = "Assigned User Role";
            this.tabAssignedUserRole.UseVisualStyleBackColor = true;
            // 
            // comboRoles
            // 
            this.comboRoles.FormattingEnabled = true;
            this.comboRoles.Location = new System.Drawing.Point(21, 37);
            this.comboRoles.Name = "comboRoles";
            this.comboRoles.Size = new System.Drawing.Size(121, 33);
            this.comboRoles.TabIndex = 1;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 497);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabAccountDetails.ResumeLayout(false);
            this.tabAccountDetails.PerformLayout();
            this.tabAssignedUserRole.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAccountDetails;
        private System.Windows.Forms.TabPage tabAssignedUserRole;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboRoles;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
    }
}
