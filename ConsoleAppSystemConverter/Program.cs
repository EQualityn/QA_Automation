using ConsoleAppSystemConverter;
using System;

namespace ConsoleAppSystemConverter
{
    class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                int number = Convert.ToInt32(args[0]);
                int baseSystem = Convert.ToInt32(args[1]);
                Console.WriteLine(SystemConverter.Convert(number,baseSystem));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Invalid input parameters");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
