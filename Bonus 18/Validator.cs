using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_18
{
    class Validator
    {
        #region Members

        public static decimal GetValidDecimal()
        {
            decimal input;
            while (!decimal.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid input.");
            }
            return input;
        }

        public static string GetValidString()
        {
            string input = Console.ReadLine();     
            while((string.IsNullOrEmpty(input)) || (string.IsNullOrWhiteSpace(input)) || (input.Length == 0))
            {
                Console.WriteLine("Please enter a valid input.");
            }
            return input;      
        }

        public static int GetValidInteger()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid input.");
            }
            return input;
        }
        //Validates that integer is within a given range
        public static int GetIntegerInRange(int min, int max)
        {
            int input = GetValidInteger();
            while (input < min || input > max)
            {
                Console.WriteLine("Please enter an integer between {0} and {1}.", min, max);
                input = GetValidInteger();
            }
            return input;
        }

        public static double GetValidDouble()
        {
            double input;
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid input.");
            }
            return input;
        }
        //Validates that integer is within a given range
        public static double GetDoubleInRange(double min, double max)
        {
            double input = GetValidInteger();
            while (input < min || input > max)
            {
                Console.WriteLine("Please enter an integer between {0} and {1}.", min, max);
                input = GetValidInteger();
            }
            return input;
        }
        #endregion
    }
}
