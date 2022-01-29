using System;

namespace Algorithmization_and_programming_HomeWork02
{
    class Program
    {
        static void Main(string[] args)
        {
            float firstNumber, secondNumber;
            string operation;
            Console.WriteLine("---\tПрограмма-калькулятор\t---");

            Console.WriteLine("Введите первое целое число или число с плавающей запятой:");            
            EnterNumber(out firstNumber);

            Console.WriteLine("Введите операцию (\'*\' умножение , \'/\' деление , \'+\' сложение , \'-\' вычитание):");
            EnterOperation(out operation);

            Console.WriteLine("Введите второе целое число или число с плавающей запятой:");
            EnterNumber(out secondNumber);

            if(operation == "*")
            {
                Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {firstNumber * secondNumber}");
            }
            else if(operation == "/")
            {
                Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {firstNumber / secondNumber}");
            }
            else if (operation == "+")
            {
                Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {firstNumber + secondNumber}");
            }
            else
            {
                Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {firstNumber - secondNumber}");
            }
        }

        static void EnterNumber (out float parseNumber)
        {
            string number = Console.ReadLine();
            if(!float.TryParse(number, out parseNumber))
            {
                Console.WriteLine("Некоректный ввод.\nВведите целое или дробное число:");
                EnterNumber(out parseNumber);
            }
        }

        static void EnterOperation(out string operation)
        {
            operation = Console.ReadLine();
            if(operation != "*" && operation != "/" && operation != "+" && operation != "-")
            {
                Console.WriteLine("Некоректный ввод.\nВведите операцию (\'*\' умножение , \'/\' деление , \'+\' сложение , \'-\' вычитание):");
                EnterOperation(out operation);
            }
        }

    }
}
