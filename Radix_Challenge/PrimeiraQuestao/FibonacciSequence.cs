using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraQuestao
{
    public class FibonacciSequence
    {
        private List<long> _seqFibo;
        public int MaiorTermo { get; } //Propriedade readonly para definir o maior termo de Fibonacci que a lista atingirá. 

        public FibonacciSequence()
        {
            MaiorTermo = 60;
            CreateSequence();
        }

        //Método que recebe o termo desejado como parâmetro e retorna o valor referente a ele (lança uma exceção caso o termo não seja entre 0 e 60).
        public long GetItem(int indice)
        {
            if(indice < 0 || indice > 60)
            {
                throw new IndexOutOfRangeException();
            }

            return _seqFibo[indice];
        }

      
        //Cria e implementa a lista _seqFibo até o termo 60 da sequência de Fibonacci. 
        private void CreateSequence()
        {
            _seqFibo = new List<long>();
            long item, ant1, ant2;

            for (int i = 0; i <= MaiorTermo; i++)
            {
                if (i == 0)
                {
                    _seqFibo.Add(0);
                    continue;
                }

                if (i == 1 || i == 2)
                {
                    _seqFibo.Add(1);
                    continue;
                }

                ant1 = _seqFibo[i - 1];
                ant2 = _seqFibo[i - 2];

                item = ant1 + ant2;

                _seqFibo.Add(item);
            }
        }
    }
}
