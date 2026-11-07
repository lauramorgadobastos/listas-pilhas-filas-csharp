using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Disponibilizada pelo professor
namespace EstruturasLineares
{
    class Lista_Linear
    {
        int[] Vetor;    // Vetor de Dados
        int Pos;        // Pos controla a quantidade de inserções...

        public Lista_Linear(int Tam)
        {
            // Construtor da Classe

            Vetor = new int[Tam];
        }

        public bool InserirInício(int x)
        {
            if (Pos < Vetor.Length)     // Se existem posições livres no Vetor...
            {
                // Vamos arrastar todos os elementos uma posição para a frente...
                for (int i = Pos; i > 0; i--)
                {
                    Vetor[i] = Vetor[i - 1];    // Arrastou.
                }

                // E agora vamos colocar o elemento no início...
                Vetor[0] = x;

                Pos++;      // Mais uma posição foi ocupada.

                // Retorna true porque deu certo a inserção.
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InserirFim(int x)
        {
            if (Pos < Vetor.Length)     // Se existem posições livres no Vetor...
            {
                Vetor[Pos] = x;         // Coloca o elemento.       

                Pos++;                  // Mais uma posição foi ocupada.

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InserirPos(int x, int Indice)
        {
            if (Pos >= Vetor.Length || Indice < 0 || Indice > Pos)
            {
                return false;
            }
            else
            {
                // Arrastar os elementos já presentes daquela posição apontada
                // para as posições da frente.
                for (int i = Pos; i > Indice; i--)
                {
                    Vetor[i] = Vetor[i - 1];
                }

                // E colocamos o elemento na posição
                Vetor[Indice] = x;

                Pos++;              // Mais uma posição foi ocupada.

                return true;        // Deu tudo certo...
            }
        }

        public bool RemoverInício()
        {
            if (Pos != 0)       // Existem posições ocupadas?
            {
                // Vamos retirar o elemento do início
                int x = Vetor[0];       // Pegamos o primeiro elemento, que será retirado

                // Atualizamos a quantidade de posições permitidas no Vetor...
                Pos--;

                // E arrastamos todos os elementos uma posição para trás.
                for (int i = 0; i < Pos; i++)
                {
                    Vetor[i] = Vetor[i + 1];
                }

                // Retornamos o elemento
                return true;
            }
            else
            {
                // Se não existem elementos para serem retirados...
                return false;
            }
        }

        public bool RemoverFim()
        {
            if (Pos != 0)       // Existem elementos no Vetor?
            {
                Pos--;          // Atualiza o total de posições disponíveis...

                return true;
            }
            else
            {
                return false;   // Não existem elementos para serem retirados
            }
        }

        public bool RemoverPos(int Indice)
        {
            if (Pos == 0 || Indice < 0 || Indice >= Pos)
            {
                return false;
            }
            else
            {
                Pos--;          // Retiramos uma posição disponível

                // E arrastamos os elementos restantes daquela posição ao final do vetor...
                for (int i = Indice; i < Pos; i++)
                {
                    Vetor[i] = Vetor[i + 1];
                }

                return true;
            }
        }

        public void MostrarLista()
        {
            Console.Clear();

            // Mostrar todos os elementos...
            Console.WriteLine("--- LISTA VETOR --- ");
            for (int i = 0; i < Pos; i++)
            {
                Console.Write($"{Vetor[i],6}");
            }
        }
    }
}
