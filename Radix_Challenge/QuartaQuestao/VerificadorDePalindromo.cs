using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartaQuestao
{
    public class VerificadorDePalindromo
    {
        public string PalavraOriginal { get; set; }

        public VerificadorDePalindromo()
        {
            
        }

        public void BuscarPalindromo(string palavra)
        {
            if (palavra.Length < 3)
            {
                Console.WriteLine("Sem resultados.");
                return;
            }
            string palavraInvertida = new String(palavra.Reverse().ToArray());

            if (palavra.Equals(palavraInvertida))
            {
                Console.WriteLine($"Palíndromo encontrado: {palavra}");
                return;
            }

            string substring = CriaSubString(palavra);

            BuscarPalindromo(substring);
        }

        private string CriaSubString(string palavra)
        {
            //for(int i = 0; i <= PalavraOriginal.Length - 3; i++)
            //{
            //    for(int j = palavra.Length -1; j >= 2; j--)
            //    {
            //        return palavra.Substring(i, j);
            //    }

            //}


        }
    }
}
