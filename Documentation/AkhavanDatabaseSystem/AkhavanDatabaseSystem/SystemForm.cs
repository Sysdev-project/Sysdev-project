using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkhavanDatabaseSystem
{
    public partial class SystemForm : Form
    {
        public SystemForm()
        {
            InitializeComponent();

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            homeUserControl2.BringToFront();
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            inventoryUserControl1.BringToFront();
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            reportsUserControl1.BringToFront();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            var newLogIn = new LogInForm();
            newLogIn.Show();
            this.Close();
        }
    }
}
