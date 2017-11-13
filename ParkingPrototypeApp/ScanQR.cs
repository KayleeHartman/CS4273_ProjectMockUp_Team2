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
    public partial class ScanQR : Form
    {
        public ScanQR()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            //after 10 seconds, move on to payment total page.
            Payment page = new Payment();
            page.Show();
            this.Hide();            
        }
    }
}
