using System;

namespace ByteBank {
    class Program {
        static void Main (string[] args) {

            #region Cadastro do Cliente.

            Console.WriteLine ("ByteBank - Cadastro de Clientes");
            Console.Write ("Nome: ");
            string nome = Console.ReadLine ();
            Console.Write ("CPF: ");
            string cpf = Console.ReadLine ();
            Console.Write ("Email: ");
            string email = Console.ReadLine ();

            Cliente cliente1 = new Cliente (nome, cpf, email);
            System.Console.WriteLine (cliente1.Senha);

            bool trocouSenha = false;
            do {
                Console.Write ("Senha: ");
                string senha = Console.ReadLine ();
                trocouSenha = cliente1.TrocaSenha (senha);
                if (trocouSenha) {
                    Console.WriteLine ("Senha alterada com sucesso!");
                } else {
                    Console.WriteLine ("Senha Inválida");
                }

            } while (!trocouSenha);
            System.Console.WriteLine ();
            #endregion
            #region Cadastro da Conta.

            System.Console.WriteLine ();
            System.Console.WriteLine ("ByteBank - Cadastro da Conta");

            System.Console.Write ("Entre com a Agencia: ");
            int agencia = int.Parse (Console.ReadLine ());

            System.Console.Write ("Entre com a conta: ");
            int conta = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Entre com o nome do titular: ");
            string titular = Console.ReadLine ();

            ContaCorrente contaCorrente1 = new ContaCorrente (agencia, conta, titular);
            double saldo;
            do {
                Console.Write ("Entre com o saldo: ");
                saldo = double.Parse (Console.ReadLine ());
                if (saldo >= 0) {
                    contaCorrente1.Deposito(saldo);
                } else {
                    System.Console.WriteLine ("Valor do saldo deve ser positivo.");
                }
            } while (saldo < 0);
            Console.WriteLine ();
            #endregion

            Cliente cliente2 = new Cliente ("Cesar", "123-123.123-12", "1@a.com");
            ContaCorrente contaCorrente2 = new ContaCorrente (123, 312, cliente2);

            #region Depósito.
            Cliente usuario = contaCorrente1.Titular;
            Console.WriteLine ("ByteBank -  Depósito em Conta");
            Console.WriteLine ($"Bem Vindo - {usuario.Nome}");
            Console.WriteLine ($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente1.Numero}");
            System.Console.WriteLine ();
            System.Console.WriteLine ("Digite o valor do Deposito: ");
            double valor = double.Parse (Console.ReadLine ());
            contaCorrente1.Deposito (valor);
            System.Console.WriteLine ();
            System.Console.WriteLine ($"Novo Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine ();
            #endregion   

            #region Saque.
            Cliente usuario = contaCorrente1.Titular;
            Console.WriteLine ("ByteBank - Saque");
            Console.WriteLine ($"Bem Vindo - {usuario.Nome}");
            Console.WriteLine ($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente1.Numero}");
            System.Console.WriteLine ();
            System.Console.WriteLine ("Digite o valor do Saque: ");
            valor = double.Parse (Console.ReadLine ());
            contaCorrente1.Saque (valor);
            System.Console.WriteLine ();
            System.Console.WriteLine ($"Novo Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine ();
            #endregion 

            #region Transferência.
            Cliente usuario = contaCorrente1.Titular;
            Console.WriteLine ("ByteBank - Transferência");
            Console.WriteLine ($"Bem Vindo - {usuario.Nome}");
            Console.WriteLine ($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente1.Numero}");
            System.Console.WriteLine ();
            System.Console.WriteLine ("Digite o valor da Transferência: ");
            valor = double.Parse (Console.ReadLine ());
            if (contaCorrente1.transferencia (contaCorrente2, valor)) {
                System.Console.WriteLine ("Transferência Efetuada");
            }

            contaCorrente1.Saque (valor);
            System.Console.WriteLine ();
            System.Console.WriteLine ($"Novo Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine ();
            #endregion                                
        }

    }
}