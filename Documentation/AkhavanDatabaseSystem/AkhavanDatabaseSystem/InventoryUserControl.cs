using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkhavanDatabaseSystem
{
    public partial class InventoryUserControl : UserControl
    {
        public InventoryUserControl()
        {
            InitializeComponent();
        }

        private void searchByNameRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (searchByNameRadioBtn.Checked)
            {
                searchTextBox.Text = "Item Name";
                searchTextBox.ForeColor = Color.Silver;
            }
            else
            {
                searchTextBox.Text = "Item Number";
                searchTextBox.ForeColor = Color.Silver;
            }
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            if ((searchTextBox.Text == "Item Name" || searchTextBox.Text == "Item Number") && searchTextBox.ForeColor == Color.Silver)
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = Color.Black;
            }
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                if (searchByNameRadioBtn.Checked)
                {
                    searchTextBox.Text = "Item Name";
                    searchTextBox.ForeColor = Color.Silver;
                }
                else
                {
                    searchTextBox.Text = "Item Number";
                    searchTextBox.ForeColor = Color.Silver;
                }
            }
        }
    }
}
