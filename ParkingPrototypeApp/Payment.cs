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
        // Declared all the variables globally such that they can be used in other methods
        double totalCost = 0;
        double extrasCost = 0;
        double timeCost = 0;
        double carWash = 3;
        double valetParking = 4;
        double carSecurity = 5;
        Random rand = new Random();
        int randomNumber = 0;

        public Payment()
        {
            InitializeComponent();
            

            //the only thing needed here is that whatever was selected from the Extras page 
            //needs to be displayed here
            //and the total cost on the Extras page will needed to be updated.
            //then change the total price.
            //Do Not CHANGE ANYTHING ELSE.      -Sara Richardson

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

        //Main method Which takes care of the logic of generating extras 
        // As soon as this page gets loaded, this method gets executed first

        private void Payment_Load(object sender, EventArgs e)
        {
            randomNumber = rand.Next(1, 7);

            //Switch case for the extras that can be selected and calculating the price for them accordingly.
            switch (randomNumber)
            {
                case 1:
                    timeCost = 1.41;
                    extrasCost = carWash;
                    totalCost = extrasCost + timeCost;
                    label4.Text = " Carwash ";
                    extrasCostLabel.Text = "$" + extrasCost;
                    label5.Text = "1 Hr 25Mins ";
                    timeCostLabel.Text = "$" + timeCost;
                    totalCostLabel.Text = "$" + totalCost;
                    break;
                case 2:
                    timeCost = 5.10;
                    extrasCost = valetParking;
                    totalCost = extrasCost + timeCost;
                    label4.Text = " Valet Parking ";
                    extrasCostLabel.Text = "$" + extrasCost;
                    label5.Text = "5 Hr 10Mins ";
                    timeCostLabel.Text = "$" + timeCost;
                    totalCostLabel.Text = "$" + totalCost;
                    break;
                case 3:
                    timeCost = 3.78;
                    extrasCost = carSecurity;
                    totalCost = extrasCost + timeCost;
                    label4.Text = " Car Security ";
                    extrasCostLabel.Text = "$" + extrasCost;
                    label5.Text = "3 Hr 45Mins ";
                    timeCostLabel.Text = "$" + timeCost;
                    totalCostLabel.Text = "$" + totalCost;
                    break;
                case 4:
                    timeCost = 2.5;
                    extrasCost = carWash + valetParking;
                    totalCost = extrasCost + timeCost;
                    label4.Text = " Carwash,Valet Parking ";
                    extrasCostLabel.Text = "$" + extrasCost;
                    label5.Text = "2 Hr 30Mins ";
                    timeCostLabel.Text = "$" + timeCost;
                    totalCostLabel.Text = "$" + totalCost;
                    break;
                case 5:
                    timeCost = 4.25;
                    extrasCost = carWash + carSecurity;
                    totalCost = extrasCost + timeCost;
                    label4.Text = " Carwash,Car Security ";
                    extrasCostLabel.Text = "$" + extrasCost;
                    label5.Text = "4 Hr 15Mins ";
                    timeCostLabel.Text = "$" + timeCost;
                    totalCostLabel.Text = "$" + totalCost;
                    break;
                case 6:
                    timeCost = 0.30;
                    extrasCost = valetParking + carSecurity;
                    totalCost = extrasCost + timeCost;
                    label4.Text = " Valet Parking,Car Security ";
                    extrasCostLabel.Text = "$" + extrasCost;
                    label5.Text = "0 Hr 30Mins ";
                    timeCostLabel.Text = "$" + timeCost;
                    totalCostLabel.Text = "$" + totalCost;
                    break;
                case 7:
                    timeCost = 1.0;
                    extrasCost = carWash + valetParking + carSecurity;
                    totalCost = extrasCost + timeCost;
                    label4.Text = " Carwash,Valet Parking,Car Security ";
                    extrasCostLabel.Text = "$" + extrasCost;
                    label5.Text = "1 Hr 0Mins ";
                    timeCostLabel.Text = "$" + timeCost;
                    totalCostLabel.Text = "$" + totalCost;
                    break;

                default:
                    break;
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
