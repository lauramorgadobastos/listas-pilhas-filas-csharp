namespace EstruturasLineares
{
    using System.Globalization;

    class Pilha // Encadeada
    {
        private Elemento Topo;
        private Elemento Aux;

        public int Tamanho;

        public Pilha()
        {
            Topo = null;
            Tamanho = 0;
        }

        public void InserirElemPilha(int valor) //  Coloca novo elemento no topo
        {
            Elemento novo = new Elemento();

            novo.Num = valor;
            novo.Prox = Topo;
            Topo = novo;

            Tamanho++;
        }

        public void RetirarElemPilha() // Retira elemento do topo
        {
            if (Topo == null)
                Console.WriteLine("A pilha está vazia! Não há como retirar elementos!");

            else
            {
                Console.WriteLine($"O elemento {Topo.Num} foi retirado com sucesso");
                Topo = Topo.Prox;
                Tamanho--;
            }
        }

          public void PreencherPilhaRandom(int quantidade, int sup) // Preenche pilha com números aleatórios 
        {
            Random x = new Random();
            Console.WriteLine($"\nSorteando {quantidade} números de 1 até {sup}:");
            Console.WriteLine("Elementos adicionados:");
            for (int i = 0; i < quantidade; i++)
            {
                int valor = x.Next(1, sup + 1);
                InserirElemPilha(valor);
                Console.Write($"{valor} "); 
            }
        }

        public void MostrarPilha() // Exibe pilha
        {
            Console.Clear();
            if (Topo == null)
                Console.WriteLine("A pilha está vazia!!");

            else
            {
                Aux = Topo;
                Console.WriteLine($"--- PILHA (Topo) | Total de elementos: {Tamanho} ---");
                while (Aux != null)
                {
                    Console.WriteLine($"{Aux.Num,5}");
                    Aux = Aux.Prox;
                }
                Console.WriteLine("--- PILHA (Fim) ---");
            }
        }
        public void LimparPilha() // Limpa pilha
        {
            if (Topo == null)
                Console.WriteLine("A pilha já está vazia!");

            else
            {
                Console.WriteLine("A pilha foi limpa com sucesso! ");
                Topo = null;
                Tamanho = 0;
            }
        }
    }
}