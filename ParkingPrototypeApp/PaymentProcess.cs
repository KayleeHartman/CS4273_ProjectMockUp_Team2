using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingPrototypeApp {
	public partial class PaymentProcess : Form {
		public PaymentProcess()	{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			long i;
			int j;
			bool a = true;
			bool b = true;
			bool c = true;
			bool d = true;

			// checks if the cvv has the correct length
			if (textBox2.TextLength != 3) {
				MessageBox.Show("CVV must be 3 digits.");
				a = false;
			}

			// notifies when the length of card number is incorrect
			if (textBox1.TextLength != 16) {
				MessageBox.Show("Card Number must be 16 digits.");
				b = false;
			}

			// prompts error message to correct CVV when incorrect input type is entered
			if (!(int.TryParse(textBox2.Text, out j))) {
				MessageBox.Show("CVV must be numerical characters.");
				c = false;
			}

			// prompts error message to correct Card no when incorrect input type is entered
			if (!(Int64.TryParse(textBox1.Text, out i))) {
				MessageBox.Show("Card Number must be numerical characters.");
				d = false;
			}
			
			if (a && b && c && d) {
				ThankYouPage page = new ThankYouPage();
				page.Show();
				this.Hide();
			}
		}

		private void button2_Click(object sender, EventArgs e) {
			Payment page = new Payment();
			page.Show();
			this.Hide();
		}

		// this makes sure that the user cannot enter past date as expiration date
		private void PaymentProcess_Load(object sender, EventArgs e) {
			dateTimePicker1.MinDate = System.DateTime.Today;
		}
	}
}