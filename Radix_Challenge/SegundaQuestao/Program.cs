using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaQuestao
{
    public class Program
    {
        static void Main(string[] args)
        {
            int qtdTestes;
            int numero;

            Console.WriteLine("Digite o número de testes que devem ser feitos.");
            qtdTestes = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < qtdTestes; i++)
            {
                Console.WriteLine("Digite um número entre 1 e 108 inclusive.");
                numero = Int32.Parse(Console.ReadLine());

                try
                {
                    if (EhPerfeito(numero)) 
                    {
                        Console.WriteLine($"\n{numero} eh perfeito!\n");
                    }
                    else
                    {
                        Console.WriteLine($"\n{numero} não eh perfeito!\n");
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("\nO número deve estar entre 1 e 108!\n");
                }
            }
            Console.ReadLine();
        }

        //Returna True se o número é perfeito ou False caso não seja. Pode lançar uma exceção se o número estiver fora do range estipulado (1 até 108).
        public static bool EhPerfeito(int numero)
        {
            int soma = 0;

            if(numero < 1 || numero > 108)
            {
                throw new ArgumentOutOfRangeException();
            }

            for(int i = 1; i < numero; i++)
            {
                if(numero % i == 0) //Verifica se número é divisível por i.
                {
                    soma += i; //soma todos os divisores do número e guarda numa variável.
                }
            }
            return soma == numero;
        }
    }
}
