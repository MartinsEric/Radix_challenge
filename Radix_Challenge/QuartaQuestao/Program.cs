using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuartaQuestao
{
    public class Program
    {
        static void Main(string[] args)
        {
            int qtdTestes;
            string palavra;
            var verificador = new VerificadorDePalindromo();

            Console.WriteLine("Digite o número de testes que devem ser feitos.");
            qtdTestes = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < qtdTestes; i++)
            {
                Console.WriteLine("Digite a palavra que deseja testar.");
                palavra = Console.ReadLine();
                
                if (!PalavraEhValida(palavra))
                {
                    Console.WriteLine("Entrada inválida!");
                    continue;
                }

                verificador.PalavraOriginal = palavra;

                while (!verificador.EhPalindromo(palavra))
                {
                    if(palavra.Length == 2)
                    {
                        Console.WriteLine("Sem resultado!");
                    }


                }
            }

            Console.ReadLine();
        }


        public static bool PalavraEhValida(string palavra)
        {
            //Verifica se a palavra tem até 100 caracteres.
            if (palavra.Where(c => char.IsNumber(c)).Count() == 0 && palavra.Count() <= 100)
            {
                return true;
            }
            return false;
        }
    }
}
