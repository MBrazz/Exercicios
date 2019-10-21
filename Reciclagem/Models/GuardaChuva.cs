using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GuardaChuva : Objeto, IVermelho, IAmarelo
    {
         public bool ReciclarPlastico()
        {
            System.Console.WriteLine("Recliclando o material feito de PLASTICO!");
            return true;
        }

        public bool ReciclarMetal()
        {
            System.Console.WriteLine("Reciclando o material feito de METAL!");
            return true;
        }
    }
}