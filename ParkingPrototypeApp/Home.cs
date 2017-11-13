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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

			Button[] buttonArray = new Button [20];
			buttonArray[0] = button01;
			buttonArray[1] = button02;
			buttonArray[2] = button03;
			buttonArray[3] = button04;
			buttonArray[4] = button05;
			buttonArray[5] = button06;
			buttonArray[6] = button07;
			buttonArray[7] = button08;
			buttonArray[8] = button09;
			buttonArray[9] = button10;
			buttonArray[10] = button11;
			buttonArray[11] = button12;
			buttonArray[12] = button13;
			buttonArray[13] = button14;
			buttonArray[14] = button15;
			buttonArray[15] = button16;
			buttonArray[16] = button17;
			buttonArray[17] = button18;
			buttonArray[18] = button19;
			buttonArray[19] = button20;

		}

		private void buttonClick(object sender, EventArgs e)
        {
			//if button clicked is green, continue on to "Extras" page.
			Extras page = new Extras();
			page.Show();
			this.Hide();
		}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(selectFloorCB.Text == "First Floor")
            {
                //make all the buttons say "L1 - x"
                for(int i = 1; i <= 15; i++)
                {
                  
                }
            }
            else if(selectFloorCB.Text == "Second Floor")
            {
                //second floor

            }else if(selectFloorCB.Text == "Third Floor")
            {
                //third floor


            }else if(selectFloorCB.Text == "Fourth Floor")
            {
                //fourth floor

            }else
            {
                //fifth floor.
            }
        }
	}
}
