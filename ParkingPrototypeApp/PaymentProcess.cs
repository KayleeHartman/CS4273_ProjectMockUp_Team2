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
    public partial class PaymentProcess : Form
    {
        public PaymentProcess()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //make sure card number is an integer
            //make sure user entered a card number
            //make sure CVV number is an integer
            //make sure user entered a CVV number
            //make sure expiration date is not today's date.
            //make sure expiration date cannot go back in time. - Sara Richardson


            //go to thank you page.
            ThankYouPage page = new ThankYouPage();
            page.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //go back to credit or debit
            Payment page = new Payment();
            page.Show();
            this.Hide();
        }
    }
}
