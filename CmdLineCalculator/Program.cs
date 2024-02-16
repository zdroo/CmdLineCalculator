using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdLineCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;
            double num1, num2;

            Console.WriteLine("Enter the Operator (+, -, *, /,^)");
            op = Console.ReadLine()[0];

            Console.WriteLine("Enter two numbers one by one");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, Calculator.Add(num1,num2));    //placeholders
                    break;

                case '-':
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, Calculator.Substract(num1,num2));
                    break;

                case '*':
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, Calculator.Multiply(num1, num2));
                    break;

                case '/':
                    if (num2 == 0.0)
                        Console.WriteLine("Divide by zero situation");
                    else
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, Calculator.Divide(num1, num2));
                    break;

                case '^':
                    Console.WriteLine("{0} ^ {1} = {2}", num1, num2, Calculator.PowerRaise(num1,num2));
                    break;

                default:
                    Console.WriteLine("{0} is an invalid operator", op);
                    break;

            }

            //switch (op)
            //{
            //    case '+':
            //        Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));    //placeholders
            //        break;

            //    case '-':
            //        Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));
            //        break;

            //    case '*':
            //        Console.WriteLine("{0} * {1} = {2}", num1, num2, (num1 * num2));
            //        break;

            //    case '/':
            //        if (num2 == 0.0)
            //            Console.WriteLine("Divide by zero situation");
            //        else
            //            Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2));
            //        break;

            //    case '^':                                        
            //        Console.WriteLine("{0} ^ {1} = {2}", num1, num2, Math.Pow(num1,num2));
            //        break;

            //    default:
            //        Console.WriteLine("{0} is an invalid operator", op);
            //        break;

            //}
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
