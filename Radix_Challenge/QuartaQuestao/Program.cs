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
                    Console.WriteLine("\nEntrada inválida!\n");
                    continue;
                }

                verificador.PalavraOriginal = palavra;

                //looping infinito até que um dos breaks sejam assionados.
                while (true)
                {
                    if (verificador.EhPalindromo(palavra))
                    {
                        Console.WriteLine("\n" + palavra + "\n");
                        break;
                    }

                    if(verificador.IndiceInicial + 2 >= verificador.PalavraOriginal.Length - 1)
                    {
                        Console.WriteLine("\nSem resultado!\n");
                        break;
                    }
                    palavra = verificador.CriaSubString(palavra);
                }
            }

            Console.ReadLine();
        }


        public static bool PalavraEhValida(string palavra)
        {
            //Verifica se a palavra não contém números e se possui até 100 caracteres.
            return palavra.Where(c => char.IsNumber(c)).Count() == 0 && palavra.Count() <= 100;
            
            
        }
    }
}
