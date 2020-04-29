using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AkhavanDatabaseSystem.Reports;

namespace AkhavanDatabaseSystem
{
    public partial class ReportsUserControl : UserControl
    {
        public ReportsUserControl()
        {
            InitializeComponent();

            StoreStockChart storeStockChart = new StoreStockChart();
            storeStockChart.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(storeStockChart);
            storeStockChart.BringToFront();
        }

        public Panel PnlContainer
        {
            get
            {
                return reportPanel;
            }
            set { reportPanel = value; }
        }

        private void storeStockChartBtn_Click(object sender, EventArgs e)
        {
            int index = PnlContainer.Controls.IndexOfKey("StoreStockChart");
            PnlContainer.Controls[index].BringToFront();
        }

        private void bestSellersBtn_Click(object sender, EventArgs e)
        {

            if (PnlContainer.Controls.ContainsKey("BestSellers"))
            {
                int index = PnlContainer.Controls.IndexOfKey("BestSellers");
                PnlContainer.Controls[index].BringToFront();
            }
            else
            {
                BestSellers bestSellers = new BestSellers();
                bestSellers.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(bestSellers);
                bestSellers.BringToFront();
            }
        }

        private void productQuantityAlertBtn_Click(object sender, EventArgs e)
        {
            if (PnlContainer.Controls.ContainsKey("ProductQuantityAlert"))
            {
                int index = PnlContainer.Controls.IndexOfKey("ProductQuantityAlert");
                PnlContainer.Controls[index].BringToFront();
            }
            else
            {
                ProductQuantityAlert productQuantityAlert = new ProductQuantityAlert();

                productQuantityAlert.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(productQuantityAlert);
                productQuantityAlert.BringToFront();
            }
        }

        private void salesReportBtn_Click(object sender, EventArgs e)
        {
            if (PnlContainer.Controls.ContainsKey("SalesReport"))
            {
                int index = PnlContainer.Controls.IndexOfKey("SalesReport");
                PnlContainer.Controls[index].BringToFront();
            }
            else
            {
                SalesReport salesReport = new SalesReport();

                salesReport.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(salesReport);
                salesReport.BringToFront();
            }
        }

        private void staffReportBtn_Click(object sender, EventArgs e)
        {
            if (PnlContainer.Controls.ContainsKey("StaffReport"))
            {
                int index = PnlContainer.Controls.IndexOfKey("StaffReport");
                PnlContainer.Controls[index].BringToFront();
            }
            else
            {
                StaffReport staffReport = new StaffReport();
                staffReport.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(staffReport);
                staffReport.BringToFront();
            }
        }

    }
}
