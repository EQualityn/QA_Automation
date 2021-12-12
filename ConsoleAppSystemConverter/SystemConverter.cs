using System;
using System.Text;

namespace ConsoleAppSystemConverter
{
    public class SystemConverter
    {
        private const int lowestNumberSystem = 2;
        private const int biggestNumberSystem = 20;

        /// <summary>
        /// Converts any number from decimal number system to any system with base from 2 to 20. 
        /// </summary>
        /// <param name="number"> Number to convert. </param>
        /// <param name="baseSystem"> Base of the system to convert to. </param>
        /// <returns> Returns number converted to base system </returns>
        public static int Convert(int number, int baseSystem)
        {
            if (baseSystem < lowestNumberSystem || baseSystem > biggestNumberSystem)
            {
                throw new ArgumentOutOfRangeException(nameof(baseSystem), "Invalid number system to convert in");
            }
            bool isNegative = false;
            if (number < 0)
            {
                isNegative = true;
                number = -number;
            }
            StringBuilder convertedString = new StringBuilder();

            while (number != 0)
            {
                int digit = number % baseSystem;
                if (digit < 10)
                {
                    convertedString.Insert(0, digit);
                }
                else
                {
                    convertedString.Insert(0, (char)(55 + digit)); 
                }
                number /= baseSystem;
            } 
            if(isNegative)
            {
                return -int.Parse(convertedString.ToString());
            }
            else
            { 
                return int.Parse(convertedString.ToString());
            }
                
        }   
    }
}
