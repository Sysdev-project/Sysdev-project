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

        static SystemForm _obj;

        public static SystemForm Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new SystemForm();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get
            {
                return panelContainer;
            }
            set { panelContainer = value; }
        }


        public SystemForm()
        {
            InitializeComponent();

            HomeUserControl homeUserControl = new HomeUserControl();
            homeUserControl.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(homeUserControl);
            homeUserControl.BringToFront();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
                int index = PnlContainer.Controls.IndexOfKey("HomeUserControl");
            PnlContainer.Controls[index].BringToFront();
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            if (PnlContainer.Controls.ContainsKey("InventoryUserControl"))
            {
                int index = PnlContainer.Controls.IndexOfKey("InventoryUserControl");
                PnlContainer.Controls[index].BringToFront();
            }
            else
            {
                InventoryUserControl inventoryUserControl = new InventoryUserControl();
                inventoryUserControl.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(inventoryUserControl);
                inventoryUserControl.BringToFront();
            }
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            if (PnlContainer.Controls.ContainsKey("ReportsUserControl"))
            {
                int index = PnlContainer.Controls.IndexOfKey("ReportsUserControl");
                PnlContainer.Controls[index].BringToFront();
            }
            else
            {
                ReportsUserControl reportsUserControl = new ReportsUserControl();
                reportsUserControl.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(reportsUserControl);
                reportsUserControl.BringToFront();
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            var newLogIn = new LogInForm();
            newLogIn.Show();
            this.Close();
        }
    }
}
