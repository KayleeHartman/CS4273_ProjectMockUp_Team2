using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//THIS PAGE IS DONE - Sara Richardson
namespace ParkingPrototypeApp
{
    public partial class ChooseSpot : Form
    {
		List<Button> buttonList = new List<Button>();
		List<Int32> firstSpots = new List<Int32>();
		List<Int32> secondSpots = new List<Int32>();
		List<Int32> thirdSpots = new List<Int32>();
		List<Int32> fourthSpots = new List<Int32>();
		List<Int32> fifthSpots = new List<Int32>();

		List<List<Int32>> floorLists = new List<List<Int32>>();
		Random rdm = new Random();

		public ChooseSpot()
        {
            InitializeComponent();
		}

		private void buttonClick(object sender, EventArgs e)
        {
			//if button clicked is green, continue on to "Extras" page. - Sara Richardson
			Extras page = new Extras();
			page.Show();
			this.Hide();
		}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			for (int i = 0; i < buttonList.Count; i++)
			{
				buttonList[i].Enabled = true;
				if (i < 17)
				{
					buttonList[i].BackColor = Color.LimeGreen;
				}
				else
				{
					buttonList[i].BackColor = Color.RoyalBlue;
				}
			}
			string floor = selectFloorCB.Text;
			switch (floor) {
				case "First Floor":
					for (int i = 0; i < buttonList.Count; i++) {
						buttonList[i].Text = ("L1 - " + (i + 1));
						for (int j = 0; j < firstSpots.Count; j++) {
							if (i == firstSpots.ElementAt(j))
							{
								buttonList[i].Enabled = false;
								buttonList[i].BackColor = Control.DefaultBackColor;
							}
						}
					}
					break;
				case "Second Floor":
					for (int i = 0; i < buttonList.Count; i++)
					{
						buttonList[i].Text = ("L2 - " + (i + 1));
						for (int j = 0; j < secondSpots.Count; j++)
						{
							if (i == secondSpots.ElementAt(j))
							{
								buttonList[i].Enabled = false;
								buttonList[i].BackColor = Control.DefaultBackColor;
							}
						}
					}
					break;
				case "Third Floor":
					for (int i = 0; i < buttonList.Count; i++)
					{
						buttonList[i].Text = ("L3 - " + (i + 1));
						for (int j = 0; j < thirdSpots.Count; j++)
						{
							if (i == thirdSpots.ElementAt(j))
							{
								buttonList[i].Enabled = false;
								buttonList[i].BackColor = Control.DefaultBackColor;
							}
						}
					}
					break;
				case "Fourth Floor":
					for (int i = 0; i < buttonList.Count; i++)
					{
						buttonList[i].Text = ("L4 - " + (i + 1));
						for (int j = 0; j < fourthSpots.Count; j++)
						{
							if (i == fourthSpots.ElementAt(j))
							{
								buttonList[i].Enabled = false;
								buttonList[i].BackColor = Control.DefaultBackColor;
							}
						}
					}
					break;
				case "Fifth Floor":
					for (int i = 0; i < buttonList.Count; i++)
					{
						buttonList[i].Text = ("L5 - " + (i + 1));
						for (int j = 0; j < fifthSpots.Count; j++)
						{
							if (i == fifthSpots.ElementAt(j))
							{
								buttonList[i].Enabled = false;
								buttonList[i].BackColor = Control.DefaultBackColor;
							}
						}
					}
					break;
				default:
					break;
			}
        }

		void comboBox1_MouseWheel(object sender, MouseEventArgs e)
		{
			((HandledMouseEventArgs)e).Handled = true;
		}

		private void Home_Load(object sender, EventArgs e)
		{
          
            buttonList.Add(button01);
			buttonList.Add(button02);
			buttonList.Add(button03);
			buttonList.Add(button04);
			buttonList.Add(button05);
			buttonList.Add(button06);
			buttonList.Add(button07);
			buttonList.Add(button08);
			buttonList.Add(button09);
			buttonList.Add(button10);
			buttonList.Add(button11);
			buttonList.Add(button12);
			buttonList.Add(button13);
			buttonList.Add(button14);
			buttonList.Add(button15);
			buttonList.Add(button16);
			buttonList.Add(button17);
			buttonList.Add(button18);
			buttonList.Add(button19);
			buttonList.Add(button20);

			floorLists.Add(firstSpots);
			floorLists.Add(secondSpots);
			floorLists.Add(thirdSpots);
			floorLists.Add(fourthSpots);
			floorLists.Add(fifthSpots);

			for (int j = 0; j < floorLists.Count; j++)
			{
				int numOfAvailable = rdm.Next(0, buttonList.Count);
				for (int i = 0; i < numOfAvailable; i++)
				{
					int randSpot = rdm.Next(0, buttonList.Count);
					floorLists.ElementAt(j).Add(randSpot);
				}
			}

			selectFloorCB.Text = "First Floor";
			selectFloorCB.SelectedIndexChanged += new System.EventHandler(comboBox1_SelectedIndexChanged);
			selectFloorCB.MouseWheel += new MouseEventHandler(comboBox1_MouseWheel);
		}

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn page = new LogIn();
            page.Show();
            this.Hide();
        }
    }
}
