using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//THIS PAGE IS DONE by Sara Richardson
namespace ParkingPrototypeApp
{
    public partial class ThankYouPage : Form
    {
        public ThankYouPage()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //after 8 seconds, go back to start page.
            timer1.Enabled = false;
            LogIn page = new LogIn();
            page.Show();
            this.Hide();
        }
    }
}
