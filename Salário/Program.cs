using System;

namespace Salário
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, salarionovo;
            Console.Write("Digite o sálario: ");
            salario = double.Parse(Console.ReadLine());

            if(salario<500){
            salarionovo=salario+(salario* 0.30);
            Console.WriteLine("O sálario NOVO é: " + salarionovo);
            }
            else Console.WriteLine("Não houve aumento");
        }
    }
}
