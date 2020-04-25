using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;

namespace AkhavanDatabaseSystem
{
    public partial class LogInUserControl : UserControl
    {
        public LogInUserControl()
        {
            InitializeComponent();
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if(usernameTextBox.Text == "Employee Id" && usernameTextBox.ForeColor == Color.Silver)
            {
                usernameTextBox.Text = "";
                usernameTextBox.ForeColor = Color.Black;
            }
        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
            {
                usernameTextBox.ForeColor = Color.Silver;
                usernameTextBox.Text = "Employee Id";
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if(passwordTextBox.Text == "Password" && passwordTextBox.ForeColor == Color.Silver)
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.Black;
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.ForeColor = Color.Silver;
                passwordTextBox.Text = "Password";
                passwordTextBox.PasswordChar = '\0';
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //This is where username and password validation occurs (only allow the code below to occur if the values match)
            var newSystemForm = new SystemForm();
            newSystemForm.Show();
            var parent = ParentForm as LogInForm;
            parent.Close();
        }

        private void exitAppBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
