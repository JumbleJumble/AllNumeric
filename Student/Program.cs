using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            char[] charArray = Console.ReadLine().ToCharArray();
            if (IsCharArrayNumeric(charArray))
            {
                Console.WriteLine("All characters are numeric");
            }
            else
            {
                Console.WriteLine("Array contains non-numeric characters");
            }
        }

        private static bool IsCharArrayNumeric(char[] charArray)
        {
            for (int i = 0; i < charArray.Length; i++)
            {
                if (!char.IsNumber(charArray[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}