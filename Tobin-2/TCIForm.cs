/* Project:     Project 2
 * Programmer:  Chris Tobin
 * Date:        3.1.2010
 * Description: A Program for Technology Correspondence Institute that will assist them in placing orders
 *              for students wishing to take technology training classes.
 *              
 *              I attempted the extra credit but couldn't get it working like it should. I have commented 
 *              out everything having to do with the extra credit. The program works fine if it is not 
 *              commented out, I just couldn't get it up to the specifications of the project so I decided
 *              to leave it out.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tobin_2
{
    public partial class TCIForm : Form
    {
        // Declare the constants. I made these decimals because in all likelyhood these prices would 
        // change at some point. If they changed to a decimal value, a change in data type would
        // not be needed.
        private const decimal IN_STATE_RATE_Decimal = 49.00m;
        private const decimal OUT_OF_STATE_RATE_Decimal = 99.00m;

        // Declare class level variables
        private decimal coursesTotalDecimal = 0;
        private decimal chargeDecimal = 0;
        private decimal totalPriceDecimal = 0;
        private string registrationString, residenceStatusString,
            cardTypeString; //coursesString;
            
        public TCIForm()
        {
            InitializeComponent();
        }

        private void tCIForm_Load(object sender, EventArgs e)
        {
            // Set form defaults
            masterCardRadioButton.Checked = true;
            inStateRadioButton.Checked = true;
        }

        private void fallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Whatever registration button is selected, display the term when the user selects
            // the save button.                         
            if (fallRadioButton.Checked)
            {
                registrationString = fallRadioButton.Text;
            }
            else if (springRadioButton.Checked)
            {
                registrationString = springRadioButton.Text;
            }
            else if (summerRadioButton.Checked)
            {
                registrationString = summerRadioButton.Text;
            }
        }
        
        private void beginningExcelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If the beginning excel check box is selected, add 1 to the total number of courses
            // selected. If it is delselected, subtract 1 from the number of courses selected
            if (beginningExcelCheckBox.Checked)
            {
                coursesTotalDecimal++;                
            }
            else
            {
                coursesTotalDecimal--;
            }

            coursesOrderedLabel.Text = coursesTotalDecimal.ToString("N0");
            pricePerCourseLabel.Text = chargeDecimal.ToString("C");
            totalPriceDecimal = chargeDecimal * coursesTotalDecimal;
            totalPriceLabel.Text = totalPriceDecimal.ToString("C");
        }

        private void beginningPowerPointCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If the beginning powerpoint check box is selected, add 1 to the total number of courses
            // selected. If it is delselected, subtract 1 from the number of courses selected
            if (beginningPowerPointCheckBox.Checked)
            {
                coursesTotalDecimal++;                
            }
            else
            {
                coursesTotalDecimal--;
            }
            
            coursesOrderedLabel.Text = coursesTotalDecimal.ToString("N0");
            pricePerCourseLabel.Text = chargeDecimal.ToString("C");
            totalPriceDecimal = chargeDecimal * coursesTotalDecimal;
            totalPriceLabel.Text = totalPriceDecimal.ToString("C");
        }

        private void beginningWordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If the beginning word check box is selected, add 1 to the total number of courses
            // selected. If it is delselected, subtract 1 from the number of courses selected
            if (beginningWordCheckBox.Checked)
            {
                coursesTotalDecimal++;                
            }
            else
            {
                coursesTotalDecimal--;
            }
            
            coursesOrderedLabel.Text = coursesTotalDecimal.ToString("N0");
            pricePerCourseLabel.Text = chargeDecimal.ToString("C");
            totalPriceDecimal = chargeDecimal * coursesTotalDecimal;
            totalPriceLabel.Text = totalPriceDecimal.ToString("C");
        }

        private void advancedExcelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If the advanced excel check box is selected, add 1 to the total number of courses
            // selected. If it is delselected, subtract 1 from the number of courses selected
            if (advancedExcelCheckBox.Checked)
            {
                coursesTotalDecimal++;                
            }
            else
            {
                coursesTotalDecimal--;
            }
            
            coursesOrderedLabel.Text = coursesTotalDecimal.ToString("N0");
            pricePerCourseLabel.Text = chargeDecimal.ToString("C");
            totalPriceDecimal = chargeDecimal * coursesTotalDecimal;
            totalPriceLabel.Text = totalPriceDecimal.ToString("C");
        }

        private void advancedPowerPointCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If the advanced powerpoint check box is selected, add 1 to the total number of courses
            // selected. If it is delselected, subtract 1 from the number of courses selected

            if (advancedPowerPointCheckBox.Checked)
            {
                coursesTotalDecimal++;                
            }
            else
            {
                coursesTotalDecimal--;
            }
            
            coursesOrderedLabel.Text = coursesTotalDecimal.ToString("N0");
            pricePerCourseLabel.Text = chargeDecimal.ToString("C");
            totalPriceDecimal = chargeDecimal * coursesTotalDecimal;
            totalPriceLabel.Text = totalPriceDecimal.ToString("C");
        }

        private void advancedWordCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            // If the advanced word check box is selected, add 1 to the total number of courses
            // selected. If it is delselected, subtract 1 from the number of courses selected
            if (advancedWordCheckBox.Checked)
            {
                coursesTotalDecimal++;               
            }
            else
            {
                coursesTotalDecimal--;
            }
            
            coursesOrderedLabel.Text = coursesTotalDecimal.ToString("N0");
            pricePerCourseLabel.Text = chargeDecimal.ToString("C");
            totalPriceDecimal = chargeDecimal * coursesTotalDecimal;
            totalPriceLabel.Text = totalPriceDecimal.ToString("C");
        }

        private void inStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Determine the students residency and calculate the totals accordingly
            if (inStateRadioButton.Checked)
            {
                chargeDecimal = IN_STATE_RATE_Decimal;
                residenceStatusString = inStateRadioButton.Text;
            }
            else
            {
                chargeDecimal = OUT_OF_STATE_RATE_Decimal;
                residenceStatusString = outOfStateRadioButton.Text;
            }

            pricePerCourseLabel.Text = chargeDecimal.ToString("C");
            totalPriceDecimal = chargeDecimal * coursesTotalDecimal;
            totalPriceLabel.Text = totalPriceDecimal.ToString("C");
        }
        
        private void masterCardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Determine the card type and display whatever type the user has selcted when
            // they hit the save button
            if (masterCardRadioButton.Checked)
            {
                cardTypeString = masterCardRadioButton.Text;
            }
            else
            {
                cardTypeString = visaRadioButton.Text;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Display the information to the user
            if (coursesTotalDecimal <= 3)
            {               
                // Extra credit portion of the project. I couldn't get it all together but this 
                // is what I could come up with. The program runs perfectly even if the following
                // is not commented out. However, I could not get the exact specifications to earn
                // the extra credit so I decided to comment it out.

                /*if (beginningExcelCheckBox.Checked)
                {
                    coursesString = beginningExcelCheckBox.Text;
                }
                else if (beginningPowerPointCheckBox.Checked)
                {
                    coursesString += beginningPowerPointCheckBox.Text;
                }
                else if (beginningWordCheckBox.Checked)
                {
                    coursesString += beginningWordCheckBox.Text;
                }
                else if (advancedExcelCheckBox.Checked)
                {
                    coursesString += advancedExcelCheckBox.Text;
                }
                else if (advancedPowerPointCheckBox.Checked)
                {
                    coursesString += advancedPowerPointCheckBox.Text;
                }
                else if (advancedWordCheckBox.Checked)
                {
                    coursesString += advancedWordCheckBox.Text;
                }
                 */

                string formattedRegistrationTermString = registrationString;
                string formattedRegistrationYearString = yearTextBox.Text;
                string formattedStudentIDString = studentIDMaskedTextBox.Text;
                string formattedStudentFirstNameString = firstNameTextBox.Text;
                string formattedStudentLastNameString = lastNameTextBox.Text;
                string formattedEmailAddressString = emailTextBox.Text;
                string formattedResidenceStatus = residenceStatusString;
                string formattedTotalCoursesPurchasedString = coursesTotalDecimal.ToString("N0");
                string formattedPricePerCourseString = chargeDecimal.ToString("C");
                string formattedTotalPriceString = totalPriceDecimal.ToString("C");
                string formattedCardTypeString = cardTypeString;
                string formattedCardNumberString = cardNumberMaskedTextBox.Text;
                string formattedCardExpirationDateString = expirationDateMaskedTextBox.Text;
                //string formattedCoursesOrderedString = coursesString;

                string messageString =
                    "Registration Term: " + formattedRegistrationTermString + " " +
                        formattedRegistrationYearString + "\n" +
                    "Student ID: " + formattedStudentIDString + "\n" +
                    "Student Name: " + formattedStudentFirstNameString + " " +
                        formattedStudentLastNameString + "\n" +
                    "Email Address: " + formattedEmailAddressString + "\n" +
                    "Residence Status: " + formattedResidenceStatus + "\n" +
                    "Total Courses Purchased: " + formattedTotalCoursesPurchasedString + "\n" +
                    "Price per Course: " + formattedPricePerCourseString + "\n" +
                    "Total Price: " + formattedTotalPriceString + "\n" +
                    "Card Type: " + formattedCardTypeString + "\n" +
                    "Card Number: " + formattedCardNumberString + "\n" +
                    "Card Expiration Date: " + formattedCardExpirationDateString; 
                    //"Courses Ordered: " + formattedCoursesOrderedString; 
                                   
                MessageBox.Show (messageString, "Order Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
            }
           
            else
            {
                string messageString =
                    "Total number of courses ordered per order must be no greater than 3.";
                MessageBox.Show(messageString,
                    "Course Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Clear the form
            clearForm();
        }      

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the form
            clearForm();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // End the project
            DialogResult whichButtonDialogResult;
            whichButtonDialogResult =
                MessageBox.Show("Are you sure you wish to quit the program?", "Exit?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (whichButtonDialogResult == DialogResult.Yes)
            {
                this.Close();
            }
           
        }   

        private void clearForm()
        {
            // Clear the form
            fallRadioButton.Checked = true;
            yearTextBox.Text = "";
            studentIDMaskedTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            inStateRadioButton.Checked = true;
            beginningExcelCheckBox.Checked = false;
            beginningPowerPointCheckBox.Checked = false;
            beginningWordCheckBox.Checked = false;
            advancedExcelCheckBox.Checked = false;
            advancedPowerPointCheckBox.Checked = false;
            advancedWordCheckBox.Checked = false;
            coursesOrderedLabel.Text = "";
            pricePerCourseLabel.Text = "";
            totalPriceLabel.Text = "";
            masterCardRadioButton.Checked = true;
            cardNumberMaskedTextBox.Text = "";
            expirationDateMaskedTextBox.Text = "";
            yearTextBox.Focus();
            //coursesString = "";
        }
    }
}
