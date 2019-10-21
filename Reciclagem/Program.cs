using System;
using System.Collections.Generic;
using Reciclagem.Interfaces;
using Reciclagem.Models;

namespace Reciclagem
{

    enum QuantidadeEnum : uint
    {
        INICIAR = 1,

    };

    enum ObjetoEnum : uint
    {
        GARRAFA,
        GARRAFAPET,
        GUARDACHUVA,
        LATINHA,
        PAPELAO,
        POTEMANTEIGA
    }

    enum CategoriaEnum : uint
    {
        AZUL,
        AMARELO,
        VERMELHO,
        VERDE
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion

            bool querSair = false;
            string[] itensMenuPrincipal = Enum.GetNames(typeof(QuantidadeEnum));
            string[] itensMenuCategoria = Enum.GetNames(typeof(CategoriaEnum));

            var opcoesQuantidade = new List<string>() {
                "    - 0                         ",

            };

            int opcaoQuantidadeSelecionada = 0;

            string menuBar = "=================================";

            do
            {
                bool QuantidadeEscolhida = false;
                #region Controla o menu do tipo de Quantidade.
                do
                {
                    Console.Clear();

                    System.Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("      Seja bem-vindo(a)!        ");
                    System.Console.WriteLine("      Escolha uma Quantidade:   ");
                    Console.ResetColor();
                    System.Console.WriteLine(menuBar);

                     #region Troca a cor do item do menu.
                    for (int i = 0; i < opcoesQuantidade.Count; i++)
                    {
                        string titulo = TratarTituloMenu(itensMenuPrincipal[i]);

                        if (opcaoQuantidadeSelecionada == i)
                        {
                            DestacarOpcao(opcoesQuantidade[opcaoQuantidadeSelecionada].Replace("-", ">").Replace(i.ToString(), titulo));
                        }
                        else
                        {
                            System.Console.WriteLine(opcoesQuantidade[i].Replace(i.ToString(), titulo));
                        }
                    }
                    #endregion

                    #endregion

                    #region Lê a tecla pressionada pelo usuário e verifica a opção selecionada.
                    var key = Console.ReadKey(true).Key;

                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            opcaoQuantidadeSelecionada = opcaoQuantidadeSelecionada == 0 ? opcaoQuantidadeSelecionada : --opcaoQuantidadeSelecionada;
                            break;

                        case ConsoleKey.DownArrow:
                            opcaoQuantidadeSelecionada = opcaoQuantidadeSelecionada == opcoesQuantidade.Count - 1 ? opcaoQuantidadeSelecionada : ++opcaoQuantidadeSelecionada;
                            break;

                        case ConsoleKey.Enter:
                            QuantidadeEscolhida = true;
                            break;
                    }
                    #endregion

                    } while (!QuantidadeEscolhida);
                #endregion
                
                bool lixeiraCompleta = false;
                int vagas = 0;

                #region Adiciona os objetos a lixeira escolhida.

                switch (opcaoQuantidadeSelecionada)
                {
                    #region Identificação de Objetos para as lixeiras.
                    case 0:
                        vagas = 6;
                        do
                        {
                            ExibirMenu();

                            Console.Write($"Digite o código do Objeto Azul: ");
                            int codigo = int.Parse(Console.ReadLine());
                            var item = Deposito.Itens[codigo];

                            Type interfaceEncontrada = item.GetType().GetInterface("IAzul");

                            if (interfaceEncontrada != null)
                            {
                                vagas--;
                                ReciclarLixo((IAzul)item);
                            }
                            else
                            {
                                Console.WriteLine("O Objeto selecionado não faz parte da lixeira Azul.");
                                continue;
                            }

                            Console.Write($"Digite o código do Objeto Amarelo: ");
                            codigo = int.Parse(Console.ReadLine());
                            item = Deposito.Itens[codigo];
                            interfaceEncontrada = item.GetType().GetInterface("IAmarelo");

                            if (interfaceEncontrada != null)
                            {
                                vagas--;
                                ReciclarLixo((IAmarelo)item);
                            }
                            else
                            {
                                Console.WriteLine("O Objeto selecionado não faz parte da lixeira Amarela."); 
                                continue;
                            }

                            Console.Write($"Digite o código do Objeto Vermelho: ");
                            codigo = int.Parse(Console.ReadLine());
                            item = Deposito.Itens[codigo];
                            interfaceEncontrada = item.GetType().GetInterface("IVermelho");

                            if (interfaceEncontrada != null)
                            {
                                vagas--;
                                ReciclarLixo((IVermelho)item);
                            }
                            else
                            {
                                Console.WriteLine("O Objeto selecionado não faz parte da lixeira Vermelha."); 
                                continue;
                            }

                            if (vagas == 0)
                            {
                                lixeiraCompleta = true;
                            }

                            } while (!lixeiraCompleta);
                        System.Console.WriteLine("Reciclagem feita com sucesso!");
                        Console.ReadLine();
                        break;
                    #endregion
                }
        
            } while (!querSair);
        }

        #region Adiciona instrumentos na banda.
        public static bool ReciclarLixo(IAzul azul)
        {
            azul.ReciclarPapel();
            System.Console.WriteLine(azul.GetType().BaseType + " o item foi Reciclado");
            return true;
        }

        public static bool ReciclarLixo(IAmarelo amarelo)
        {
            amarelo.ReciclarMetal();
            System.Console.WriteLine(amarelo.GetType().BaseType + " o item foi Reciclado");
            return true;
        }

        public static bool ReciclarLixo(IVermelho vermelho)
        {
            vermelho.ReciclarPlastico();
            System.Console.WriteLine(vermelho.GetType().BaseType + " o item foi Reciclado");
            return true;
        }
        #endregion

        public static void DestacarOpcao(string opcao)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine(opcao);
            Console.ResetColor();
        }


        public static void ExibirMenu()
        {
            var objetos = Enum.GetNames(typeof(ObjetoEnum));
            int codigo = 1;
            string menuItemBorda = "##############################";

            System.Console.WriteLine(menuItemBorda);
            System.Console.WriteLine("#                             #");
            System.Console.WriteLine("#           Objetos           #");
            System.Console.WriteLine("#                             #");
            System.Console.WriteLine(menuItemBorda);

            foreach (var item in objetos)
            {
                System.Console.WriteLine($"  {codigo++}.{TratarTituloMenu(item)}");
            }

            System.Console.WriteLine(menuItemBorda);
        }

        public static string TratarTituloMenu(string titulo)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titulo.Replace("_", " ").ToLower());
        }
    }
}

#endregion
