using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string oper;

        
            Console.Write("Digite o 1º número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o operador: ");
            oper = Console.ReadLine();

            if (oper == "+") {
            Console.Write($"{num1} + {num2} = {num1 + num2}");
            } 
            else if (oper == "-") {
            Console.Write($"{num1} - {num2} = {num1 - num2}");
            }
            else if (oper == "*") {
            Console.Write($"{num1} * {num2} = {num1 * num2}");
            } 
            else if (oper == "/") {
            Console.Write($"{num1} / {num2} = {num1 / num2}");
            }
            else if (oper == "%") {
            Console.Write($"{num1} % {num2} = {num1 % num2}");
            }
            else 
            Console.Write("Operação Inválida");

        }
    }
}
