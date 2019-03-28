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
        public int IndiceInicial { get; private set; }

        public VerificadorDePalindromo()
        {
            IndiceInicial = 0;
        }

        public bool EhPalindromo(string palavra)
        {
            palavra = RemoverAcentuacao(palavra).ToLower();

            string palavraInvertida = new String(palavra.Reverse().ToArray());            

            if (palavra.Equals(palavraInvertida))
            {
                return true;
            }

            return false;
        }

        private string CriaSubString(string palavra)
        {
            int novoFinal = palavra.Length;
            novoFinal--;
        }

        private string RemoverAcentuacao(string palavra)
        {
            palavra = palavra.Replace("À", "A");
            palavra = palavra.Replace("Â", "A");
            palavra = palavra.Replace("Á", "A");
            palavra = palavra.Replace("Ã", "A");
            
            palavra = palavra.Replace("à", "a");
            palavra = palavra.Replace("â", "a");
            palavra = palavra.Replace("á", "a");
            palavra = palavra.Replace("ã", "a");
           
            palavra = palavra.Replace("Ê", "E");
            palavra = palavra.Replace("É", "E");
            
            palavra = palavra.Replace("ê", "e");
            palavra = palavra.Replace("é", "e");

            palavra = palavra.Replace("Í", "i");

            palavra = palavra.Replace("í", "i");

            palavra = palavra.Replace("Ó", "O");
            palavra = palavra.Replace("Ô", "O");
            
            palavra = palavra.Replace("ó", "o");
            palavra = palavra.Replace("ô", "o");
            
            palavra = palavra.Replace("ú", "u");

            return palavra;
        }
    }
}
