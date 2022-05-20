using System;

namespace reverseOrderofNumbers
{
    class Program
    {
        static void Main(string[] args)

        {

            int[] numbers = new int[5];
            int[] reverse = new int[5];
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter the number {i+1} : ");
                numbers[i] = int.Parse(Console.ReadLine());
            
                while (numbers[i] > 0)
                {
                    reverse [i]= reverse[i] * 10+ numbers[i] % 10;
                    numbers[i] = numbers[i] / 10;
                }
                    Console.WriteLine($"Reversed number : {reverse[i]}");
                Console.WriteLine("");

              
            }
        }
    }
}








