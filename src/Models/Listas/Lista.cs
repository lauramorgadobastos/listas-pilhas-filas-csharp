namespace EstruturasLineares
{
    class Lista // Encadeada
    {
        private Elemento Primeiro;
        public int Tamanho { get; private set; }

        public Lista()
        {
            Primeiro = null;
            Tamanho = 0;
        }

        public void InserirInicioLista(int valor)   //  Inserir no Início
        {
            Elemento novo = new Elemento(valor);
            novo.Prox = Primeiro;
            Primeiro = novo;
            Tamanho++;
            Console.WriteLine($" Elemento {valor} inserido no início da lista.");
        }

        public void InserirFimLista(int valor)  // Inserir no Fim
        {
            Elemento novo = new Elemento(valor);
            if (Primeiro == null)
            {
                Primeiro = novo;
            }
            else
            {
                Elemento aux = Primeiro;
                while (aux.Prox != null)
                {
                    aux = aux.Prox;
                }
                aux.Prox = novo;
            }
            Tamanho++;
            Console.WriteLine($" Elemento {valor} inserido no fim da lista.");
        }

        public bool InserirPosicaoLista(int valor, int posicao)  // Inserir em Determinada Posição
        {
            if (posicao < 0 || posicao > Tamanho)
            {
                Console.WriteLine(" Posição inválida!");
                return false;
            }

            if (posicao == 0)
            {
                InserirInicioLista(valor);
                return true;
            }

            Elemento novo = new Elemento(valor);
            Elemento aux = Primeiro;

            for (int i = 0; i < posicao - 1; i++)
            {
                aux = aux.Prox;
            }

            novo.Prox = aux.Prox;
            aux.Prox = novo;
            Tamanho++;
            Console.WriteLine($" Elemento {valor} inserido na posição {posicao}.");
            return true;
        }

        public void PreencherListaRandomIni(int quantidade, int sup)  // Preencher Lista Aleatoriamente Início
        {
            Random x = new Random();
            Console.WriteLine($"\nSorteando {quantidade} números de 0 até {sup}:");
            Console.WriteLine("Elementos adicionados:");
            for (int i = 0; i < quantidade; i++)
            {
                int valor = x.Next(0, sup + 1);
                InserirInicioLista(valor);
                Console.Write($"{valor} ");
            }
            Console.WriteLine("\n\n Preenchimento concluído!");
        }

        public void PreencherListaRandomFim(int quantidade, int sup)  // Preencher Lista Aleatoriamente Fim
        {
            Random x = new Random();
            Console.WriteLine($"\nSorteando {quantidade} números de 0 até {sup}:");
            Console.WriteLine("Elementos adicionados:");
            for (int i = 0; i < quantidade; i++)
            {
                int valor = x.Next(0, sup + 1);
                InserirFimLista(valor);
                Console.Write($"{valor} ");
            }
            Console.WriteLine("\n\n Preenchimento concluído!");
        }

        public void RemoverInicio() // Remover do Início
        {
            if (Primeiro == null)
            {
                Console.WriteLine(" A lista está vazia!");
            }
            else
            {
                Console.WriteLine($" Elemento {Primeiro.Num} removido do início.");
                Primeiro = Primeiro.Prox;
                Tamanho--;
            }
        }

        public void RemoverFim()   // Remover do Fim
        {
            if (Primeiro == null)
            {
                Console.WriteLine(" A lista está vazia!");
                return;
            }

            if (Primeiro.Prox == null)
            {
                Console.WriteLine($" Elemento {Primeiro.Num} removido do fim.");
                Primeiro = null;
            }
            else
            {
                Elemento aux = Primeiro;
                while (aux.Prox.Prox != null)
                {
                    aux = aux.Prox;
                }
                Console.WriteLine($" Elemento {aux.Prox.Num} removido do fim.");
                aux.Prox = null;
            }
            Tamanho--;
        }

        public bool RemoverElemento(int valor)  // Remover determinado elemento pelo seu VALOR
        {
            if (Primeiro == null)
            {
                Console.WriteLine(" A lista está vazia!");
                return false;
            }

            if (Primeiro.Num == valor)
            {
                Primeiro = Primeiro.Prox;
                Tamanho--;
                Console.WriteLine($" Elemento {valor} removido da lista.");
                return true;
            }

            Elemento aux = Primeiro;
            while (aux.Prox != null && aux.Prox.Num != valor)
            {
                aux = aux.Prox;
            }

            if (aux.Prox == null)
            {
                Console.WriteLine($" Elemento {valor} não foi encontrado na lista.");
                return false;
            }

            aux.Prox = aux.Prox.Prox;
            Tamanho--;
            Console.WriteLine($" Elemento {valor} removido da lista.");
            return true;
        }

        public void MostrarLista() // Exibir Lista 
        {
            Console.Clear();
            if (Primeiro == null)
            {
                Console.WriteLine("A lista está vazia!!");
            }
            else
            {
                Elemento aux = Primeiro;
                Console.WriteLine($"--- LISTA ENCADEADA | Total de Elementos: {Tamanho} ---");
                while (aux != null)
                {
                    Console.Write($"[{aux.Num}] -> ");
                    aux = aux.Prox;
                }
                Console.WriteLine("null");
            }
        }

        public void LimparLista()  //  Limpar Lista
        {
            Primeiro = null;
            Tamanho = 0;
            Console.WriteLine(" A lista foi limpa com sucesso!");
        }
    }
}
