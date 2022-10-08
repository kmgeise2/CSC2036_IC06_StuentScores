using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC2036_IC06_StuentScores
{
    internal class Validator
    {
        // Class is static so field must be static
        private static string title = "Entry Error";

        // This is a property
        public static string Title
        {
            get { return title; }
            set { title = value; }
        }
        //Check to see if user entered a value 
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " must enter a name.", Title);
                return false;
            }
            else
            {
                return true;
            }
        }
        //Check that an integer is present
        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }
        /****************************************************
        * Add this code HERE
        * Check to see if entry is between a specified range
        *****************************************************/ 
    }
}
