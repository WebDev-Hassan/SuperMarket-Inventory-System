using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace SuperMarket_Inventory_System
{
    public partial class Dashboard : Form
    {
        BusinessLogic BL = new BusinessLogic();
        public Dashboard(User u)
        {
            InitializeComponent();
        }
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            DashboardPages.SetPage(0);
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            DashboardPages.SetPage(1);
            DisplayProducts();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            DashboardPages.SetPage(2);
        }

        private void btn_transactions_Click(object sender, EventArgs e)
        {
            DashboardPages.SetPage(3);
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            DashboardPages.SetPage(4);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DashboardPages.SetPage(5);
        }

        private void DashboardReport_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            DashboardPages.SetPage(0);
            btn_dashboard.selected = true;
            btn_exit.selected = false;
        }
        #region Utilities
        private void DisplayProducts()
        {
            DGV_Products.Rows.Clear();
            var list = BL.GetAllProducts();
            foreach (var i in list)
            {
                DGV_Products.Rows.Add(i.ID,i.Title,i.Quantity,i.SalePrice,i.PurchasePrice);
            }
        }
        #endregion

        private void DGV_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
