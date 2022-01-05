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
        }

    }
}
