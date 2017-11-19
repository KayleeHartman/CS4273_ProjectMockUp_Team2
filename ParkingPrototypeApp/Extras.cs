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
    public partial class Extras : Form
    {
        public static int totalPrice = 0;
        public static int flag1 = 0;
        public static int flag2 = 0;
        public static int flag3 = 0;

        public Extras()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //confirm button go to ticket page. By Sara Richardson
            GenerateQRCodePage page = new GenerateQRCodePage();
            page.Show();
            this.Hide();
        }

        private void ExtrasCheckbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //I went ahead and created some variables for you all to get you guys started.
            //The variable names are self-explanatory, so all you guys need to do 
            //is check to see which item was selected
            //if the first item was selected, add "firstItem" to "totalPrice"
            //if the second item was selected, add "secondItem" to "totalPrice"
            //if the third item was selected, add "thirdItem" to "totalPrice"
            //- Sara Richardson




            int firstItem = 3;     //$10
            int secondItem = 4;     //$9
            int thirdItem = 5;     //$15

            //Add total for each clicked and update the costTotalLabel.      
            //the following code does not work, it's just a head start for you all 
            //to get an idea of what it would possibly look like. - Sara Richardson

            if (extrasCheckbox.SelectedIndex == 0)
            {
                if (flag1 == 1)

                {
                    totalPrice = totalPrice - firstItem;
                    flag1 = 0;

                }
                else
                {
                    totalPrice = totalPrice + firstItem;
                    costTotalLabel.Text = "+ $" + totalPrice;
                    flag1 = 1;
                }

            }


            if (extrasCheckbox.SelectedIndex == 1)
            {
                if (flag2 == 1)

                {
                    totalPrice = totalPrice - secondItem;
                    flag2 = 0;

                }
                else
                {
                    totalPrice = totalPrice + secondItem;
                    costTotalLabel.Text = "+ $" + totalPrice;
                    flag2 = 1;
                }

            }
            if (extrasCheckbox.SelectedIndex == 2)
            {
                if (flag3 == 1)

                {
                    totalPrice = totalPrice - thirdItem;
                    flag3 = 0;

                }
                else
                {
                    totalPrice = totalPrice + thirdItem;
                    costTotalLabel.Text = "+ $" + totalPrice;
                    flag3 = 1;
                }

            }

            //do not use this code, it is a placeholder so some error won't say
            //these variables aren't being used.
            // totalPrice = firstItem + secondItem + thirdItem;    //do not use this code.

            //use this
            costTotalLabel.Text = "+ $" + totalPrice;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //go back to home page
            ChooseSpot page = new ChooseSpot();
            page.Show();
            this.Hide();
        }

        private void Extras_Load(object sender, EventArgs e)
        {

        }
    }
}

