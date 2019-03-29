using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestaoBonus
{
    public class Program
    {
        static void Main(string[] args)
        {
            int qtdTestes;
            string[] escolhas = new string[2];
            string sheldon, raj;

            Console.WriteLine("Digite o número de testes que serão feitos (máx 100).");
            qtdTestes = Int32.Parse(Console.ReadLine());

            if(qtdTestes > 100)
            {
                Console.WriteLine("Poderão ocorrer no máximo 100 testes.");
            }
            else
            {
                for(int i = 0; i < qtdTestes; i++)
                {
                    Console.WriteLine("Insira a escolha de Sheldon e Raj respectivamente" +
                                      "as separando por um espaço. (pedra, papel, tesoura," +
                                      "lagarto ou spock");

                    escolhas = Console.ReadLine().Split(' ');
                    sheldon = escolhas[0];
                    raj = escolhas[1];

                    ImprimirResultado(sheldon, raj);// função resposável pelo resultado. 
                }
            }
            Console.ReadLine();
        }
        
        private static void ImprimirResultado(string sheldon, string raj)
        {
            //Entradas sempre em letra minúscula para não atrapalhar as comparações.
            sheldon = sheldon.ToLower();
            raj = raj.ToLower();

            //Sheldon vitorioso.
            if((sheldon == "tesoura" && raj == "papel" || sheldon == "tesoura" && raj == "lagarto") || 
               (sheldon == "pedra" && raj == "tesoura" || sheldon == "pedra" && raj == "lagarto") ||
               (sheldon == "papel" && raj == "pedra" || sheldon == "papel" && raj == "spock") ||
               (sheldon == "lagarto" && raj == "spock" || sheldon == "lagarto" && raj == "papel") ||
               (sheldon == "spock" && raj == "tesoura" || sheldon == "spock" && raj == "pedra"))
            {
                Console.WriteLine("\nCaso #1: Bazinga!\n");
            }
            
            //Raj vitorioso
            else if ((raj == "tesoura" && sheldon == "papel" || raj == "tesoura" && sheldon == "lagarto") ||
                     (raj == "pedra" && sheldon == "tesoura" || raj == "pedra" && sheldon == "lagarto") ||
                     (raj == "papel" && sheldon == "pedra" || raj == "papel" && sheldon == "spock") ||
                     (raj == "lagarto" && sheldon == "spock" || raj == "lagarto" && sheldon == "papel") ||
                     (raj == "spock" && sheldon == "tesoura" || raj == "spock" && sheldon == "pedra"))
            {
                Console.WriteLine("\nCaso #2: Raj trapaceou!\n");
            }

            //Empate
            else
            {
                Console.WriteLine("\nCaso #3: De novo!\n");
            }
        }
    }
}
