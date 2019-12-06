using System;

namespace RoleTopMVC.Models
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string Senha {get;set;}
        public string Email {get;set;}
        public DateTime DataNascimento {get;set;}
         public uint TipoUsuario {get;set;}

        public Cliente()
        {

        }

        public Cliente(string nome, string senha, string email, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Senha = senha;
            this.Email = email;
            this.DataNascimento = dataNascimento;
        }
        
    }
}