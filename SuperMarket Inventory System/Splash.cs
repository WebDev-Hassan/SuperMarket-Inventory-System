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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int progress = 0;

            if (bunifuProgressBar1.Value < 100)
            {
                bunifuProgressBar1.Value += 10;
            }
            else
            {
                timer1.Stop();
                var login = new Login();
                this.Hide();
                login.Show();
            }
        }

    }
}
