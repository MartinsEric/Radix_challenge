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

        // Retorna True ao encontrar a maior string que seja palíndrona. 
        public bool EhPalindromo(string palavra)
        {
            //Verifica se é o primeiro teste feito na palavra em questão e faz o IndiceInicial voltar a ser zero.
            if (PalavraOriginal.Equals(palavra))
            {
                IndiceInicial = 0;
            }

            palavra = RemoverAcentuacao(palavra).ToLower(); //Retorna todas as letras como minúsculas e sem acentuação.

            string palavraInvertida = new String(palavra.Reverse().ToArray());

            return palavra.Equals(palavraInvertida);
          
        }

        // Retorna as possíveis sub strings existentes na palavra.
        public string CriaSubString(string palavra)
        {
            int novoFinal;

            //Se a sub string tiver apenas 3 letras e não for palíndrona, avança o indice para testar um nova cadeia de sub strings.
            if (palavra.Length == 3 && !EhPalindromo(palavra))
            {                
                novoFinal = PalavraOriginal.Length - 1;

                palavra = PalavraOriginal.ToLower().Substring(1, novoFinal);

                IndiceInicial++;
                
                return palavra;
            }
            novoFinal = palavra.Length - 1;

            return palavra.Substring(0, novoFinal);
        }

        //Remove a acentuação da palavra, para que não tenha diferença ao comparar as letras.
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
