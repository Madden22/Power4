using System;

//This simple program asks the user for a number, and will return whether or not that number is a power of 4.

namespace Power4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input a number: ");
                double inp = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(PwrCheck(inp));
                Console.WriteLine("Want to check again? ");
                string req = Console.ReadLine();
                if (req == "no")
                {
                    break;
                }
            }
        }

        //Checks the power of the number.
        static bool PwrCheck(double num)
        {
            while (true)
            {
                if (num == 1)
                {
                    break;
                }
                else if (num == 0)
                {
                    return false;
                }
                else if (num == Math.Ceiling(num))
                {
                    num = num/4;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
