using Meu_projeto.Enum;
using System;
using System.Collections.Generic;

namespace Meu_projeto
{
    class Program
    {
        public static List<Conta> lista = new List<Conta>();
        static void Main(string[] args)
        {
             
          
            string op = OpcaoUsuario();
            while (op != "x")
            {
                switch (op)
                {
                    case "1":
                        LerContas();
                        break;
                    case "2":
                        AdicionarContas();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "c":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                op = OpcaoUsuario();
            }
        }

        private static void LerContas()
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("Não há contas!");
                return;
            }
            else
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine(lista[i]);
                }
            }
        }

        public static void AdicionarContas()
        {
            Console.WriteLine("Criando contas: ");
            Console.WriteLine("Digite 1 para pessoa física e 2 para pessoa jurídica: ");
            int entrada = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu crédito inicial");
            double credito = double.Parse(Console.ReadLine());

            Conta contanova = new Conta((TipoConta)entrada, nome, saldo, credito);
            lista.Add(contanova);
            Console.WriteLine("\n Conta criada! \n");
            return;
        }
        public static string OpcaoUsuario()
        {
            Console.WriteLine("Digite o que você deseja fazer: ");
            Console.WriteLine("1 - Listar contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string op = Console.ReadLine().ToLower();
            return op;
        }
        public static void Sacar()
        {
            Console.WriteLine("Digite o número da sua conta:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade que deseja sacar: ");
            double qtd = double.Parse(Console.ReadLine());

            lista[numero].Sacar(qtd);
        }
        public static void Depositar()
        {
            Console.WriteLine("Digite o número da sua conta:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade que deseja depositar:");
            double qtd = double.Parse(Console.ReadLine());

            lista[numero].Depositar(qtd);
        }
        public static void Transferir()
        {
            Console.WriteLine("Digite o numero da sua conta: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero da conta que deseja trasnferir: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantia que deseja transferir: ");
            double qtd = double.Parse(Console.ReadLine());

            lista[n1].Transferir(qtd, lista[n2]);
        }
    }
}
