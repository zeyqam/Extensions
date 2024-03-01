using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Extensions.Services
{
    public class CalculatorService
    {
        public double Calculation(double num1, double num2,char operation)
        {
            double result = 0;
            switch(operation)
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
                    if(num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Divided by zero error");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;


            }
            return result;
        }
    }
}
