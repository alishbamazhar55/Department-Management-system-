using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationInGUI.DL;
using ApplicationInGUI.BL;

namespace ApplicationInGUI
{
    class Validations
    {

        public static bool NameValidation(string name)
        {
            bool flag = true;
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            foreach (char c in name)
            {
                if (!Char.IsLetter(c) && !Char.IsWhiteSpace(c))
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }


        public static int IntegerValidation(string number, int upperLimit, int lowerLimit)
        {

            int result;
            bool isValidInput;
            do
            {
                isValidInput = int.TryParse(number.ToString(), out result);
                if (isValidInput)
                {

                    if (result >= lowerLimit && result <= upperLimit)
                    {
                        return result;
                    }
                    else
                    {
                        isValidInput = false;
                    }
                }
                if (!isValidInput)
                {

                    MessageBox.Show( "Enter integer again: ");

                
                    number = Console.ReadLine();
                }

            }
            while (!isValidInput);
            return result;
        }

        public static float FloatValidation(string number, int upperLimit, int lowerLimit)
        {
            float result;
            bool isValidInput;
            do
            {
                isValidInput = float.TryParse(number.ToString(), out result);
                if (isValidInput)
                {

                    if (result >= lowerLimit && result <= upperLimit)
                    {
                        return result;
                    }
                    else
                    {
                        isValidInput = false;
                    }
                }
                if (!isValidInput)
                {
                    MessageBox.Show("Enter integer again: ");
                    number = Console.ReadLine();
                }

            }
            while (!isValidInput);
            return result;
        }

    }
}
