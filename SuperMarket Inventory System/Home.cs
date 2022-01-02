using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket_Inventory_System
{
    public partial class SidePanel : Form
    {
        public SidePanel()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            Toggle(sender);
        }

        private void Toggle(object sender)
        {
            b1.BackColor = Color.FromArgb(33, 147, 25);
            //b2.BackColor = Color.FromArgb(33, 147, 176);
            //b3.BackColor = Color.FromArgb(33, 147, 176);
            //b4.BackColor = Color.FromArgb(33, 147, 176);
            //b5.BackColor = Color.FromArgb(33, 147, 176);
            //b6.BackColor = Color.FromArgb(33, 147, 176);

            //((Bunifu.Framework.UI.BunifuFlatButton)sender).BackColor = Color.FromArgb(33,147,25);
        }
    }
}
