using System;
using System.Linq;

namespace Veteran
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string enteredString = Console.ReadLine();
            bool allNumeric = AllNumeric(enteredString);
            
            string message = allNumeric
                ? "All characters are numeric"
                : "Array contains non-numeric characters";

            Console.WriteLine(message);
        }

        private static bool AllNumeric(string enteredString)
        {
            return enteredString.All(char.IsNumber);
        }
    }
}