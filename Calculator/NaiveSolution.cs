using System;
namespace Calculator
{
    public class NaiveSolution
    {
        public static void FirstNaiv()
        {
            int num1;
            int num2;
            int result;
            Console.WriteLine("This Calculat the sum of 2 number \n Enter the first number ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result}");
        }
        public static void SecNaiv()
        {
            int num1;
            int num2;
            int result;
            bool isSum;
            Console.WriteLine("This Calculat the sum\\diff of 2 number \n What you like to calculat ? if sum enter 1 else enter 0");
            isSum = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter the first number ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (isSum)
            {
                result = num1 + num2;

                Console.WriteLine($"{num1} + {num2} = {result}");
            }
            else
            {
                result = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {result}");
            }

        }

    }
}

