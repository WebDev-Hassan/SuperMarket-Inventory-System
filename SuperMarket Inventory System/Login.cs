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
using System.Text.RegularExpressions;
namespace SuperMarket_Inventory_System
{
    public partial class Login : Form
    {

        BusinessLogic BL = new BusinessLogic();

        #region Regex Patterns
        string EmailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
        string PasswordPattern = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,25}$";
        #endregion

        #region Authentication Fields
        string name;
        string email;
        string password;
        string confirmpassword;
        #endregion
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

        #region SignIn Functions
        // SignIn Button Click
        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            if (ValidateLoginFields())
            {
                User u = new User(name, email, password);
                try
                {
                    User user = BL.SignIn(u);
                    var Dashboard = new Dashboard(u);
                    this.Visible = false;
                    Dashboard.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        // Validation of SignIn Fields
        private bool ValidateLoginFields()
        {
            this.email = txt_SignInEmail.Text;
            this.password = txt_SignInPassword.Text;

            // Email Validation
            if (!Regex.IsMatch(email, EmailPattern))
            {
                MessageBox.Show("Invalid Email");
                return false;
            }
            // Password Validation
            if (!Regex.IsMatch(password, PasswordPattern))
            {
                MessageBox.Show("Invalid Password");
                return false;
            }
            return true;
        }
        #endregion

        #region SignUp Functions
        //SignUp Button Click
        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            if (ValidateRegistrationFields())
            {
                User u = new User(name, email, password);
                BL.SignUp(u);
                var Dashboard = new Dashboard(u);
                this.Visible = false;
                Dashboard.Visible = true;
            }
        }
        // Validation of SignUp Fields
        private bool ValidateRegistrationFields()
        {
            this.name = txt_SignUpName.Text;
            this.email = txt_SignUpEmail.Text;
            this.password = txt_SignUpPassword.Text;
            this.confirmpassword = txt_SignUpConfirmPassword.Text;

            // Email Validation
            if (!Regex.IsMatch(email, EmailPattern))
            {
                MessageBox.Show("Invalid Email");
                return false;
            }
            // Password Validation
            if (!Regex.IsMatch(password, PasswordPattern))
            {
                MessageBox.Show("Invalid Password");
                return false;
            }
            // Matching Passwords
            if (password != confirmpassword)
            {
                MessageBox.Show("Passwords doesn't match");
                return false;
            }
            return true;
        }


        #endregion

        #region KeyUp Events for Passwords

        //SignUp Password
        private void txt_SignUpPassword_KeyUp(object sender, KeyEventArgs e)
        {
            txt_SignUpPassword.UseSystemPasswordChar = true;
        }

        //SignUp Confirm Password
        private void txt_SignUpConfirmPassword_KeyUp(object sender, KeyEventArgs e)
        {
            txt_SignUpConfirmPassword.UseSystemPasswordChar = true;
        }

        //SignIn Password
        private void txt_SignInPassword_KeyUp(object sender, KeyEventArgs e)
        {
            txt_SignInPassword.UseSystemPasswordChar = true;
        }
        #endregion
    }
}
