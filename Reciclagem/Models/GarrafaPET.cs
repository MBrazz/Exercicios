using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GarrafaPET : Objeto, IVermelho
    {
        public bool ReciclarPlastico()
        {
            System.Console.WriteLine("Recliclando o material feito de PLASTICO!");
            return true;
        }
    }
}