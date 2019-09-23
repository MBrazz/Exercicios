using System;

namespace CalculoArea
{
    class Program
    {
        static void Main(string[] args)
        {
           string opcao = "";

            Console.WriteLine("Calcula Area");
            Console.WriteLine("1 - Triangulo");
            Console.WriteLine("2 - Quadrado");
            Console.WriteLine("3 - Losango");
            Console.WriteLine("4 - Trapezio");
            Console.WriteLine("5 - Retangulo");
            Console.WriteLine("6 - Circulo");
            opcao = Console.ReadLine();

            switch(opcao){
                case "1":
                Console.WriteLine("Área do Triangulo");
                Console.Write("Entre com a Base: ");
                double baseTri = double.Parse(Console.ReadLine());
                Console.Write("Entre com a Altura");
                double altTri = double.Parse(Console.ReadLine());
                double areaTri = (baseTri * altTri) / 2;
                Console.WriteLine("A área do triangulo é: " + areaTri);
                break;

                case "2":
                Console.WriteLine("Área do Quadrado");
                Console.Write("Qual o lado do Quadrado? ");
                double ladoQuad = double.Parse(Console.ReadLine());
                double areaQuad = (ladoQuad * ladoQuad);
                Console.WriteLine("A área do quadrado é: " + areaQuad);
                break;


            }

        }
    }
}
