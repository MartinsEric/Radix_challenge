using System;

namespace QuintaQuestao
{
    public class ContadorDeAlgarismos
    {
        private int[] _qtdAlgarismos;

        public ContadorDeAlgarismos()
        {
            /*
             * array _QtdAlgarismos irá manter na posição i a quantidade de vezes que 
             * o algarismo i aparece dentro do intervalo.
             */
            _qtdAlgarismos = new int[10]; 
        }

        public void Contar(int a, int b)
        { 
            //Garante que a seja menor que b.
            if(a > b)
            {
                int aux = a;
                a = b;
                b = aux;
            }
            
            //Percorre o intervalo (a, b)
            for(int i = a; i <= b; i++)
            {
                char[] array = i.ToString().ToCharArray(); //tranforma o numero num array de char para manipularmos todos os algarismos.
                Implementar(array);
            }
        }

        //recebe o array referente a um dos numeros do intervalo e incrementa _qtdAlgarismos referente os algarismos encontrados.
        private void Implementar(char[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                int numero = Int32.Parse(array[i].ToString());
                _qtdAlgarismos[numero]++;
            }
        }

        //Imprime na tela o array _qtdAlgarismos expondo o resultado.
        public void ImprimirResultado()
        {
            Console.WriteLine();

            foreach (var item in _qtdAlgarismos)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            ZerarContador();
        }

        //Zera todas as posições de _qtdAlgarismos para ser usado nos próximos intervalos.
        private void ZerarContador()
        {
            for(int i = 0; i < _qtdAlgarismos.Length; i++)
            {
                _qtdAlgarismos[i] = 0;
            }
        }
    }
}