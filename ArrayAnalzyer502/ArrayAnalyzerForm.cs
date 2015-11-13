/*
 * Created by: Nicholas  Ellul
 * Created on: 12-Nov-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 5-02
 * This program returns the biggest nuumber in an array.
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

namespace ArrayAnalzyer502
{
    public partial class frmArray : Form
    {
        //global declaration
        int[] arrayOfNumbers = new int[10];
        Random randomNumbers = new Random();

        public int BiggestNumber(int[] array)
        {
            //returns biggest number in array
            int elementHolder = 0;
            foreach(int element in array)
            {
                if(elementHolder < element)
                {
                    elementHolder = element;
                }
              
            }
            return elementHolder;
        }


        public frmArray()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //input
            const int NUMBER_OF_ITEMS = 10;
            int randomizedNumber;
            int greatestNumber;

            Array.Clear(arrayOfNumbers,0,arrayOfNumbers.Length);

            //process
            for (int counter = 0; counter < NUMBER_OF_ITEMS; counter++)
            {
                randomizedNumber = randomNumbers.Next(1, 10 + 1);
                arrayOfNumbers[counter] = randomizedNumber;
            }

            //output
            greatestNumber = BiggestNumber(arrayOfNumbers);

            MessageBox.Show(Convert.ToString(greatestNumber), "The greatest number is...");
           
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
