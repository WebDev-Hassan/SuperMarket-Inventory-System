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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            // Drag Events
            LoginDock.SubscribeControlToDragEvents(LoginGradientPanel);
            LoginDock.SubscribeControlToDragEvents(SignIn);
            LoginDock.SubscribeControlToDragEvents(SignUp);

            // Shows the Form on the Center of the Screen
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        #region SignUp / Login Page Navigation
        private void btn_SignInPage_Click(object sender, EventArgs e)
        {
            LoginPages.SetPage(0);
        }
        private void btn_SignUpPage_Click_1(object sender, EventArgs e)
        {
            LoginPages.SetPage(1);
        }
        #endregion
        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
