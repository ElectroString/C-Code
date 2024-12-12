/*
 * Cam Davies
 * COSC 2100
 * Assignment 1: Video Game sales Weekly average calculator
 * This program displays a form and takes in user inputted values to display the average sales profit for a week
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC_Assignment_1
{
    public partial class Form1 : Form
    {
        double defaultOutputValue = 0.00;

        // Initializes the Form
        public Form1()
        {
            InitializeComponent();
        }

        // Exits the Application when the Exit button is pressed
        private void exitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Resets the form to it's original state when Pressed
        private void resetClick(object sender, EventArgs e)
        {
            listBoxValues.Items.Clear();
            txtEntry.ReadOnly = false;
            updateOutput(defaultOutputValue);
            btn_enter.Enabled = true;
        }


        // Adds valid values in the Textbox to the list and updates the output Value
        // Displays error if invalid value is put in the Textbox
        private void enterClick(object sender, EventArgs e)
        {
            
            try
            {
                int entryDouble = System.Convert.ToInt32(txtEntry.Text);

                if (entryDouble < 0)
                {
                    MessageBox.Show("Error, Value must be Positive");
                }
                else
                {
                    listBoxValues.Items.Add(entryDouble);
                    txtEntry.Text = "";
                    updateOutput(getAverageGameSales());
                }

                if (listBoxValues.Items.Count > 6)
                {
                    txtEntry.ReadOnly = true;
                    btn_enter.Enabled = false;
                }
                

            }
            catch
            {
                if (listBoxValues.Items.Count > 6)
                {
                    MessageBox.Show("Error: Maximum Values Inputted, Please reset to add new Values");
                }
                else
                {
                    MessageBox.Show("Error, invalid Value");
                }
                
            }
        }



        // Updates the Value in the Ouput Text Box
        private void updateOutput(double newValue)
        {
            txtOutput.Text = "Average Video Game Sales: $" + newValue.ToString();
            dayLabel.Text = "Day # " + listBoxValues.Items.Count.ToString();
        }

        // Calculates the average Game Sales from values in the List Box
        private double getAverageGameSales()
        {
            double averageGameSales = 0;
            foreach (var item in listBoxValues.Items)
            {
                averageGameSales += System.Convert.ToDouble(item);
            }
            
            return Math.Round(averageGameSales/listBoxValues.Items.Count,2);
        }
    }
}
