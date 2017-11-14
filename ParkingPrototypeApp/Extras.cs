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

            int totalPrice = 0;
      
            int firstItem = 10;     //$10
            int secondItem = 9;     //$9
            int thirdItem = 15;     //$15

            //Add total for each clicked and update the costTotalLabel.      
            //the following code does not work, it's just a head start for you all 
            //to get an idea of what it would possibly look like. - Sara Richardson

            //if (extrasCheckbox.SelectedIndex.Equals("0"))
            //{
            //    totalPrice += firstItem;
            //    costTotalLabel.Text = "+ $" + totalPrice;
            //}
            //if (extrasCheckbox.SelectedIndex.Equals("1"))
            //{
            //    totalPrice += secondItem;
            //    costTotalLabel.Text = "+ $" + totalPrice;
            //}
            //if (extrasCheckbox.SelectedIndex.Equals("2"))
            //{
            //    totalPrice += thirdItem;
            //    costTotalLabel.Text = "+ $" + totalPrice;
            //}
          
            //do not use this code, it is a placeholder so some error won't say
            //these variables aren't being used.
            totalPrice = firstItem + secondItem + thirdItem;    //do not use this code.

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
    }
}
