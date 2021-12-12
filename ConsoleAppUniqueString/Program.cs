using System;


namespace ConsoleAppUniqueString
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(UniqueSymbolLength(args[0]));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Invalid format of input data");
                Console.WriteLine(ex);
            }

        }

        /// <summary>
        /// This function calculates length of the biggest sequence with non repetitive symbols.
        /// </summary>
        /// <param name="str"> String to search. </param>
        /// <returns> Returns length of the biggest sequence with non repetitive symbols in integer format. </returns>
        public static int UniqueSymbolLength(string str)
        {
            int maxUniqueLength = 0;
            int currentUniqueLength = 1;
            if (str.Length == 0)
            {
                return 0;
            }
            if (str.Length == 1)
            {
                return 1;
            }
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    currentUniqueLength = 1;
                    continue;
                }
                currentUniqueLength++;
                if (currentUniqueLength > maxUniqueLength)
                {
                    maxUniqueLength = currentUniqueLength;
                }
            }
            return maxUniqueLength;
        }
    }


}
