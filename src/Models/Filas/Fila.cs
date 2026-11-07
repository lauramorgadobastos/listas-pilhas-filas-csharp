namespace EstruturasLineares
{
    using System.Globalization;

    class Fila // Encadeada 
    {
        private Elemento Inicio;
        private Elemento Fim;
        private Elemento Aux;

        public int Tamanho;

        public Fila()
        {
            Inicio = null;
            Fim = null;
            Tamanho = 0;
        }

        public void InserirElemFila(int valor) //  Coloca novo elemento no fim da fila
        {
            Elemento novo = new Elemento();

            novo.Num = valor;
            novo.Prox = null;
            if (Inicio == null)
            {
                Inicio = novo;
                Fim = novo;
            }
            else
            {
                Fim.Prox = novo;
                Fim = novo;
            }

            Tamanho++;
        }

        public void RetirarElemFila()
        {
            if (Inicio == null)
                Console.WriteLine("A fila está vazia! Não há como retirar elementos!");
            else
            {
                Console.WriteLine($"O elemento {Inicio.Num} foi retirado com sucesso");
                Inicio = Inicio.Prox;
                Tamanho--;

                if (Inicio == null)
                    Fim = null;
            }
        }
        public void PreencherFilaRandom(int quantidade, int sup) // Preenche fila com números aleatórios 
        {
            Random x = new Random();
            Console.WriteLine($"\nSorteando {quantidade} números de 1 até {sup}:");
            Console.WriteLine("Elementos adicionados:");
            for (int i = 0; i < quantidade; i++)
            {
                int valor = x.Next(1, sup + 1);
                InserirElemFila(valor);
                Console.Write($"{valor} ");
            }
        }

        public void MostrarFila()  //  Exibe fila
        {
            Console.Clear();
            if (Inicio == null)
                Console.WriteLine("A fila está vazia!!");

            else
            {
                Aux = Inicio;
                Console.WriteLine($"| Total de elementos: {Tamanho} |");
                Console.Write("Fila (Início) -->  ");
                while (Aux != null)
                {
                    Console.Write($"{Aux.Num,5}");
                    Aux = Aux.Prox;
                }
                Console.WriteLine("  --> Fila (Fim) ");
            }
        }
        public void LimparFila() // Limpa a fila
        {
            if (Inicio == null)
                Console.WriteLine("A fila já está vazia!");

            else
            {
                Console.WriteLine("A fila foi limpa com sucesso! ");
                Inicio = null;
                Fim = null;
                Tamanho = 0;
            }
        }

    }
}