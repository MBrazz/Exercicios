using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Papelao : Objeto, IAzul
    {
        public bool ReciclarPapel()
        {
            System.Console.WriteLine("Reclicando o material feito de PAPEL!");
            return true;
        }
    }
}