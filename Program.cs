using System;

namespace sumOfnumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            int[] numbers = new int[10];

            for(n=0;n<10;n++)
            {
                Console.WriteLine($"Enter {n+1} number: ");
                numbers[n] = int.Parse(Console.ReadLine());
                
                sum += numbers[n];
            }
            Console.WriteLine($"Sum of all {n} numbers stored in array is : {sum}");
            Console.ReadLine();
        }
        

    }



}
