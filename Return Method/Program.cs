using System.Runtime.CompilerServices;

namespace Return_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 5, 6, -8, 0 };
            printNumbersStopOnNegative(numbers); 

            static void printNumbersStopOnNegative(int[] numbers)
            {
                foreach (int i in numbers)
                {
                    if (i < 0)
                    {
                        return;
                    }
                    Console.WriteLine(i);
                }
            }
        }
    }
}