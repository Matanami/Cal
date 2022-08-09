using System;
namespace Calculator
{
    public class NaiveSolution
    {
        int num1;
        int num2;
        int result;
        char operat;

        public void ConnctionToUser()
        {
            Console.WriteLine("This Calculat the sum\\diff of 2 number \n What you like to calculat ? +/-");
            operat = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the first number ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        public void Calculat()
        {
            if (operat == '+')
            {
                result = num1 + num2;
            }
            else
            {
                result = num1 - num2;

            }

        }
        public void printResult()
        {

            Console.WriteLine($"{num1} {operat} {num2} = {result}");


        }
    }

}


