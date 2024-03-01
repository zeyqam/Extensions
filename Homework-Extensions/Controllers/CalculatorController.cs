using Homework_Extensions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Extensions.Controllers
{
    public  class CalculatorController
    {
        CalculatorService calculator=new CalculatorService();

        public void Calculation()
        {
            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double num2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select the action:");
            char operation=Convert.ToChar(Console.ReadLine());

            double result=calculator.Calculation(num1, num2, operation);
            Console.WriteLine("Result: " + result);
        }

    }
    
}
