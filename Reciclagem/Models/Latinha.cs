using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Latinha : Objeto, IAmarelo
    {
        public bool ReciclarMetal()
        {
            System.Console.WriteLine("Reciclando o material feito de METAL!");
            return true;
        }
    }
}