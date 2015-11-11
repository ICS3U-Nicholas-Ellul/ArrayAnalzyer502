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
            const int NUMBER_OF_ITEMS = 10;
            int randomizedNumber;
            int greatestNumber;
          
            //process
            for (int counter = 0; counter < NUMBER_OF_ITEMS; counter++)
            {
                randomizedNumber = randomNumbers.Next(1, 10 + 1);
                arrayOfNumbers[counter] = randomizedNumber;
            }

            //output
            greatestNumber = BiggestNumber(arrayOfNumbers);

            MessageBox.Show(Convert.ToString(greatestNumber));
           
        }
    }
}
