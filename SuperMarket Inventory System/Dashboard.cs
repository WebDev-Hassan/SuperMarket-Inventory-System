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
            label1.Text = u.ID.ToString();
            label2.Text = u.Name;
            label3.Text = u.Email;
            label4.Text = u.Password;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
