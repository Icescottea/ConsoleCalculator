using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Console Calculator! ");

            while(true)
            {
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the operator (+, -, *, /): ");
                char operation = Console.ReadLine()[0];

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed. ");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operator.");
                        continue;
                }

                Console.WriteLine($"Result: {result}");

                Console.Write("Do you want to perform another calculation? (y/n): ");
                char continueCalc = Console.ReadLine()[0];
                if (continueCalc != 'y' && continueCalc != 'Y')
                {
                    break;
                }

            }

            Console.WriteLine("Thank you for using the Console Calculator! ");
            Console.ReadKey();
        }
    }
}
