using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//THIS PAGE IS NOT DONE - Sara Richardson
namespace ParkingPrototypeApp
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            int totalCost = 0;
            int extraCost = 0;
            int timeCost = 0;

            //the only thing needed here is that whatever was selected from the Extras page 
            //needs to be displayed here
            //and the total cost on the Extras page will needed to be updated.
            //then change the total price.
            //Do Not CHANGE ANYTHING ELSE.      -Sara Richardson

            totalCost = extraCost + timeCost;

            totalCostLabel.Text = "$" + totalCost;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //go to payment process page
            PaymentProcess page = new PaymentProcess();
            page.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //go to payment process page
            PaymentProcess page = new PaymentProcess();
            page.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn page = new LogIn();
            page.Show();
            this.Hide();
        }
    }
}
