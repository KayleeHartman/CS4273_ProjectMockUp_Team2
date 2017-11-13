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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Go to Scan Page
            ScanQR page = new ScanQR();
            page.Show();
            this.Hide();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            //Go to Home Page
            Home page = new Home();
            page.Show();
            this.Hide();
        }
    }
}
