using System;
using System.Linq;

namespace sortTheNumbers
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.Write("Please enter a number(no decimals, please!): ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a number(no decimals, please!): ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a number(no decimals, please!): ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a number(no decimals, please!): ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a number(no decimals, please!): ");
            int num5 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a number(no decimals, please!): ");
            int num6 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a number(no decimals, please!): ");
            int num7 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a number(no decimals, please!): ");
            int num8 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a number(no decimals, please!): ");
            int num9 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a number(no decimals, please!): ");
            int num10 = Convert.ToInt32(Console.ReadLine());


            int[] numbers = { num1, num2, num3, num4, num5, num6, num7, num8, num9, num10 };

            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
               
            }

            Console.WriteLine($"{numbers[0]} {numbers[9]}");

            var firstNum = numbers.First();
            var lastNum = numbers.Last();

            Console.WriteLine($"{firstNum} {lastNum}");

            Console.ReadKey();
        }
    }
}    

