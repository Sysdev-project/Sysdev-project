using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkhavanDatabaseSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            Visible = false;

            InitializeComponent();
            var newLogInForm = new LogInForm();
            newLogInForm.Show();
        }
    }
}
