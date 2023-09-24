namespace Number_Of_Positive_Numbers_Inside_An_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = new [] {1,2,2,3, -5,-6,-7,8,9,};

            int a=countThePositiveNumbers (numbers);
            Console.WriteLine(a);

            static int countThePositiveNumbers (int [] numbers)
            {
                int count = 0;
                foreach (int number in numbers)
                {   
                    if (number > 0)
                    {
                        count++;
                    }
                    
                }
                return count;

            }
        }
    }
}