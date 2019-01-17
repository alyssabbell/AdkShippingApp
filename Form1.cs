/*
 * Name: Alyssa Bell
 * Date: 2/28/2017
 * Filename: AdirondackShippingLtd
 * Purpose/Description: This program allows the user to calculate the shipping cost and volume of their package.
 * Error Checking: This program forces the user to enter values greater than 0 for all measurements. It also checks
 * for empty fields, forcing the user to enter a value before the data can be submitted and stored.
 * Assumptions: The user will not enter any characters where numerical values are to be entered.
 * Also, that distances are entered only in whole numbers. 
 *  * Summary of Methods: 
 * - public float CalculateVolume() - returns the volume of the package
 * - public float CalculateCost() - calculates the shipping cost of the package based on the shipping distance
 *      and weight of the package
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdirondackShippingLtd
{
    public partial class Form1 : Form
    {
        bool emptyField = false;
      
        public Form1()
        {
            InitializeComponent();
        }

        public void submitBtn_Click(object sender, EventArgs e)
        {
            emptyField = true;
           PackageInfoClass package = new PackageInfoClass();

            if (pckgCotentsTxtBx.Text == string.Empty)
            {
                MessageBox.Show("Please enter the content of your package.");
                pckgCotentsTxtBx.Focus();
            }

            else if (pckgLengthTxtBx.Text == string.Empty || float.Parse(pckgLengthTxtBx.Text) < 1)
            {
                MessageBox.Show("Please enter the length of your package.");
                pckgLengthTxtBx.Focus();
            }

            else if (pckgHeightTxtBx.Text == string.Empty || float.Parse(pckgHeightTxtBx.Text) < 1)
            {
                MessageBox.Show("Please enter the height of your package.");
                pckgHeightTxtBx.Focus();
            }

            else if (shipDistanceTxtBx.Text == string.Empty || int.Parse(shipDistanceTxtBx.Text) < 1)
            {
                MessageBox.Show("Please enter the distance of your package's destination in miles.");
                shipDistanceTxtBx.Focus();
            }

            else if (pckgWeightTxtBx.Text == string.Empty || float.Parse(pckgWeightTxtBx.Text) < .01)
            {
                MessageBox.Show("Please enter the weight of your package. Weight must be greater than 0.");
                pckgWeightTxtBx.Focus();
            }

            else if (pckgWidthTxtBox.Text == string.Empty || float.Parse(pckgWidthTxtBox.Text) < 1)
            {
                MessageBox.Show("Please enter the width of your package. Width must be greater than 0.");
                pckgWidthTxtBox.Focus();
            }

            else
            {
                emptyField = false;
                shipCostGrp.Enabled = true;

                package.GetPackageContents = pckgCotentsTxtBx.Text;
                package.GetShipMiles = int.Parse(shipDistanceTxtBx.Text);
                package.GetPckgLength = float.Parse(pckgLengthTxtBx.Text);
                package.GetPckgWidth = float.Parse(pckgWidthTxtBox.Text);
                package.GetPckgHeight = float.Parse(pckgHeightTxtBx.Text);
                package.GetPckgWeight = float.Parse(pckgWeightTxtBx.Text);



                // Call the Calculate Volume Method from PackageInfoClass
                pckgSizeTxtBx.Text = "Your package is " + String.Format("{0:0.00}", package.CalculateVolume()) + " cubic inches.";
                // Call the Calculate Cost Method from the PackageInfoClass
                shipCostTxtBx.Text = "Your package will cost $" + String.Format("{0:0.00}", package.CalculateCost()) + " to ship.";
    
            }
     
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            pckgCotentsTxtBx.Clear();
            shipDistanceTxtBx.Clear();
            pckgLengthTxtBx.Clear();
            pckgWeightTxtBx.Clear();
            pckgWidthTxtBox.Clear();
            pckgHeightTxtBx.Clear();

            pckgSizeTxtBx.Clear();
            shipCostTxtBx.Clear();

            shipCostGrp.Enabled = false;
            pckgCotentsTxtBx.Focus();
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
