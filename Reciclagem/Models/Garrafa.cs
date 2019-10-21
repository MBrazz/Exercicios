using System;
using Reciclagem.Interfaces;


namespace Reciclagem.Models
{
    public class Garrafa : Objeto, IVerde
    {
        public bool ReciclarVidro()
        {
            System.Console.WriteLine("Recliclando o material feito de VIDRO!");
            return true;
        }
    }
}