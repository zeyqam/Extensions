
using Homework_Extensions.Controllers;
using Homework_Extensions.Extensions;
using Homework_Extensions.Services;

//string email1 = "cavid@example.com";
//string email2 = "cavid.example.com";
//Console.WriteLine("Does email have @?" + email1.HasAtSymbol());
//Console.WriteLine("Does email have @?" + email2.HasAtSymbol());

//string password1 = "password123";
//string password2 = "pass";
//Console.WriteLine("Is password1 length valid?"+password1.IsPasswordLengthValid());
//Console.WriteLine(" is Password length valid "+password2.IsPasswordLengthValid());

//int[] numbers = { 1, 2, 3, 4, 5, 6 };
//Console.WriteLine(numbers.Product());

//CalculatorService calculator = new CalculatorService();
//Console.WriteLine("Enter first number:");
//int num1=Convert.ToInt32( Console.ReadLine());
CalculatorController calculatorController = new();
calculatorController.Calculation();