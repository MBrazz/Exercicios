﻿using System;

namespace AnodeNascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade= 0 ;
            int ano= 0 ;


            do{
            Console.Write("Digite o ano em que você nasceu: ");
            ano = int.Parse(Console.ReadLine());
            if((ano > 2019) || (ano < 0)){
                Console.WriteLine("Data Inválida");
                }
            }while ((ano > 2019) || (ano < 0));

            idade = 2019 - ano;

            if(idade < 3){
            Console.WriteLine("Recém-Nascido");
            }
            else if ((idade>=3) && (idade<=11)){
            Console.WriteLine("Criança");
            }

            else if ((idade>12) && (idade <= 19)){
                Console.WriteLine("Adolecente");
            }

            else if ((idade>20) && (idade <= 65)){
                Console.WriteLine("Adulto");
            }
           
           else if (idade > 65 ){
               Console.WriteLine("Idoso");
           }
        }
    }
}
