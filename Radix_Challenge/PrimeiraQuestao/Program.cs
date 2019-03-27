using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraQuestao
{
    
    public class Program
    {
        /* 
         * O método Main é responsável por definir quantos testes serão feitos, instanciar a classe FibonacciSequence (onde toda lógica do problema foi implementada) e tratar
         *  a eventual exceção que seu método poderá lançar.
         */
        static void Main(string[] args)
        {
            int qtdTestes, termo;
            long resultado;
            var fibo = new FibonacciSequence();

            Console.WriteLine("Digite quantos testes serão feitos.");
            qtdTestes = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < qtdTestes; i++)
            {
                Console.WriteLine("Digite o enésimo termo que deseja buscar.");
                termo = Int32.Parse(Console.ReadLine());

                try
                {
                    resultado = fibo.GetItem(termo);
                    Console.WriteLine($"fibo({termo}) = {resultado}");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Só é permitido buscar do termo 0 ao 60 da sequência de Fibonacci.");
                }
            }

            Console.ReadLine();
        }
    }
}
