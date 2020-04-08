using System;
using System.Globalization;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            char escolha;
            string nome;
            int conta;
            double deposito;
            double quantia;

            Conta dados;

            Console.Write("Entre com o número da conta: ");
            conta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do titular: ");
            nome = Console.ReadLine();
            while (nome.Length < 3)
            {
                Console.Write("Por favor insira o nome corretamente");
                Console.Write("\nEntre com o nome do titular: ");
                nome = Console.ReadLine();
            };

            Console.Write("Haverá depósito inicial (s/n)?: ");
            escolha = char.Parse(Console.ReadLine());
            while (escolha != 's' && escolha != 'n')
            {
                Console.Write("Por favor selecione a opção correta.");
                Console.Write("Deseja Fazer depósito inicial (s/n)?: ");
                escolha = char.Parse(Console.ReadLine());
            };

            if (escolha == 's')
            {

                Console.Write("Entre com o valor para depósito: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                dados = new Conta(nome, conta, deposito);

            }
            else
            {
                dados = new Conta(nome, conta);
                Console.WriteLine("\n" + dados);
                Console.WriteLine("\n");

            }
            Console.WriteLine("\n" + dados);
            Console.ReadKey();
            Console.Clear();

            Console.Write("Entre com um valor para depósito: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.adicionarValor(quantia);
            Console.WriteLine("\n" + dados);
            Console.ReadKey();
            Console.Clear();

            Console.Write("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.fazerSaque(quantia);
            Console.WriteLine("\n" + dados);
            Console.ReadKey();

        }
    }
}
