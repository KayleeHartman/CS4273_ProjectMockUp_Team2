using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingPrototypeApp
{
    public partial class GenerateQRCodePage : Form
    {
        public GenerateQRCodePage()
        {
            InitializeComponent();
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //go to start page
            LogIn page = new LogIn();
            page.Show();
            timer1.Enabled = false;
            this.Hide();
        }
    }
}
