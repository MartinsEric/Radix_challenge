using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintaQuestao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, qtdTestes;
            string[] linha = new string[2];
            var Contador = new ContadorDeAlgarismos(); //Instância da classe responsável por realizar os testes.

            Console.WriteLine("Digite a quantidade de testes que serão feitos.");
            qtdTestes = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < qtdTestes; i++)
            {
                Console.WriteLine("Digite um intervalo de números inteiros " +
                                  "entre 1 e 1000000 separados por um espaço.");
                linha = Console.ReadLine().Split(' ');

                //Exceção é lançada caso as entradas não sejam números.
                try
                {
                    a = Int32.Parse(linha[0]);
                    b = Int32.Parse(linha[1]);
                    
                    // Os números precisam estar entre 1 e 1000000 inclusive.
                    if (a < 1 || a > 1000000 || b < 1 || b > 1000000)
                    {
                        Console.WriteLine("\nOs números devem estar entra 1 e 1000000.\n");
                        continue;
                    }
                    Contador.Contar(a, b); //Chama o método responsável por realizar a contagem de algarismos.
                    Contador.ImprimirResultado(); //Imprime resultado esperado. 
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nEntrada Inválida!\n");
                }
            }
            Console.ReadLine();
        }
    }
}
