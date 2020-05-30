//Author: Kenneth Lamb
//Date: 04/13/2020
//Purpose: This program is a visual client to use the DiverClass
//Input: There is no input from the user however they cna select info on the screen that is loaded in from the file
//Processing: Sets the initial value of the file to equal the file that it needs to read
//Output: All output resulting from the various test statements is printed to the screen in the text boxes and or outputed to the divers.out


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiverClassTest;
using System.IO;

namespace DriversGUI
{
    public partial class frmMain : Form
    {
        //Initialize the class with the copy constructor inputting the filename to be used
        DiverClass divers = new DiverClass("divers.in");

        public frmMain()
        {
            InitializeComponent();
        }

        //Button to exit the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit the application.
            Application.Exit();
        }

        //Load the combo box cmbDiversName
        private void frmMain_Load(object sender, EventArgs e)
        {
            
            //Call the sort function
            divers.Sort(1);

            //For loop to fill the combo box
            for(int i = 0; i < 25; i ++)
            {
                //Call the print array method from the diversClass to fill the combo box with names
                cmbDiverName.Items.Add(divers.PrintArray(i,1));
            }
        }

        //Button used to clear the form
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDiveScore.Clear();
            txtTotalScore.Clear();
            cmbDiveNumber.SelectedIndex = -1;
            cmbDiverName.SelectedIndex = -1;
        }//End btnClear

        //This button will calculate the dive score of the diver selected and the dive number selected
        private void btnDiveScore_Click(object sender, EventArgs e)
        {
            //Error check to make sure a diver is selected
            if(cmbDiverName.SelectedIndex == -1)
            {
                MessageBox.Show("Please make a dive name selection");
            }
            else
            {
                //Error check to make sure a dive number was selected
                if (cmbDiveNumber.SelectedIndex == -1)
                {
                    MessageBox.Show("Please make a dive number selection");
                }
                else
                {
                    //Check which diver number was selected
                    if (cmbDiveNumber.Text == "1")
                    {
                        //set the DiveScore text to call the CalculateDive method from the diversClass with the dive number 1, and the index of the cmbDiverName
                        txtDiveScore.Text = (divers.CalculateDive(1, cmbDiverName.SelectedIndex)).ToString();
                    }
                    else if (cmbDiveNumber.Text == "2")
                    {
                        //set the DiveScore text to call the CalculateDive method from the diversClass with the dive number 2, and the index of the cmbDiverName
                        txtDiveScore.Text = (divers.CalculateDive(2, cmbDiverName.SelectedIndex)).ToString();
                    }
                    else
                    {
                        //set the DiveScore text to call the CalculateDive method from the diversClass with the dive number 3, and the index of the cmbDiverName
                        txtDiveScore.Text = (divers.CalculateDive(3, cmbDiverName.SelectedIndex)).ToString();
                    }
                }
            }
            
            
        }//End btnDiveScore

        //Gathers the total score of the Diver Selected
        private void btnTotalScore_Click(object sender, EventArgs e)
        {
            //Error check that a diver name is selected
            if(cmbDiverName.SelectedIndex == -1)
            {
                MessageBox.Show("Please make a diver selection");
            }
            else
            {
                //Calculate the diverscore by calling TotalScore method in the diversClass and send it the index of the cmbDiverName
                txtTotalScore.Text = (divers.totalScore(cmbDiverName.SelectedIndex)).ToString();
            }
            
        }

        //Used to create a report on the diver selected
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            //Create the streamwriter
            StreamWriter Write;
            //Create a file called divers.out
            Write = new StreamWriter("divers.out");
            //Write the titles and then call the printArray method printing the second variation
            Write.WriteLine(string.Format("{0, -25} {1, 25} {2, 25} {3, 25}", "LastName, First Initial", "1st dive's score", "2nd dive's score", "3rd dive's score"));
            Write.WriteLine(divers.PrintArray(0,2));

            //Print a new line
            Write.WriteLine(Environment.NewLine);
            
            //Write the titles and then call the printArray method printing the third variation
            Write.WriteLine(string.Format("{0, 12} {1, -21}", "Total Score", "Diver's Name"));
            Write.WriteLine(divers.PrintArray(0, 3));

            MessageBox.Show("Report Successful");
        }
    }
}
