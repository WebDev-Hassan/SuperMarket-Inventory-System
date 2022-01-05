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
            // Drag Events
            //LoginDock.SubscribeControlToDragEvents(LoginGradientPanel);
            //LoginDock.SubscribeControlToDragEvents(SignIn);
            //LoginDock.SubscribeControlToDragEvents(SignUp);

            

            // Shows the Form on the Center of the Screen
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void b1_Click(object sender, EventArgs e)
        {

            //((Bunifu.Framework.UI.BunifuFlatButton)sender).BackColor = Color.Beige;
            //MessageBox.Show("asd");
        }

        private void b6_Click(object sender, EventArgs e)
        {
            CloseApp();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CloseApp();
        }
        private void CloseApp()
        {
            if (MessageBox.Show("Do you want to close this Application", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
