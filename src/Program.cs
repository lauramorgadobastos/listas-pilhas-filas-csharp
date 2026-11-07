using System;

namespace EstruturasLineares
{
    class Program
    {
        static void Main()
        {
            bool sair = false;

            while (!sair) // Menu Principal 
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("        ESTRUTURAS DE DADOS LINEARES             ");
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Listas ");
                Console.WriteLine("2. Pilhas ");
                Console.WriteLine("3. Filas ");
                Console.WriteLine("0. Sair");
                Console.WriteLine("==================================================");
                Console.Write("Escolha a estrutura que deseja testar: ");

                string opcao = Console.ReadLine() ?? "";

                switch (opcao)
                {
                    case "1":
                        MenuOpcoesLista(); // Listas
                        break;
                    case "2":
                        MenuOpcoesPilha(); // Pilhas
                        break;
                    case "3":
                        MenuOpcoesFila(); // Filas
                        break;
                    case "0":
                        sair = true;
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida!");
                        Pausar();
                        break;
                }
            }
        }

        #region Submenus de Escolha 

        static void MenuOpcoesLista()
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("              ESCOLHA O TIPO DE LISTA             ");
            Console.WriteLine("==================================================");
            Console.WriteLine("1. Lista Linear (Estática - em Vetor -)");
            Console.WriteLine("2. Lista Encadeada (Dinâmica)");
            Console.WriteLine("0. Voltar");
            Console.WriteLine("==================================================");
            Console.Write("Opção: ");
            string opcao = Console.ReadLine() ?? "";

            if (opcao == "1")
            {
                int tam = ObterTamanhoVetor();
                Lista_Linear listaLin = new Lista_Linear(tam);
                MenuListaLinear(listaLin);
            }
            else if (opcao == "2")
            {
                Lista listaEnc = new Lista();
                MenuLista(listaEnc);
            }
        }

        static void MenuOpcoesPilha()
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("              ESCOLHA O TIPO DE PILHA             ");
            Console.WriteLine("==================================================");
            Console.WriteLine("1. Pilha Linear (Estática - em Vetor -)");
            Console.WriteLine("2. Pilha Encadeada (Dinâmica)");
            Console.WriteLine("0. Voltar");
            Console.WriteLine("==================================================");
            Console.Write("Opção: ");
            string opcao = Console.ReadLine() ?? "";

            if (opcao == "1")
            {
                int tam = ObterTamanhoVetor();
                Pilha_Linear pilhaLin = new Pilha_Linear(tam);
                MenuPilhaLinear(pilhaLin);
            }
            else if (opcao == "2")
            {
                Pilha pilhaEnc = new Pilha();
                MenuPilha(pilhaEnc);
            }
        }

        static void MenuOpcoesFila()
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("              ESCOLHA O TIPO DE FILA              ");
            Console.WriteLine("==================================================");
            Console.WriteLine("1. Fila Linear (Estática - em Vetor -)");
            Console.WriteLine("2. Fila Encadeada (Dinâmica)");
            Console.WriteLine("0. Voltar");
            Console.WriteLine("==================================================");
            Console.Write("Opção: ");
            string opcao = Console.ReadLine() ?? "";

            if (opcao == "1")
            {
                int tam = ObterTamanhoVetor();
                Fila_Linear filaLin = new Fila_Linear(tam);
                MenuFilaLinear(filaLin);
            }
            else if (opcao == "2")
            {
                Fila filaEnc = new Fila();
                MenuFila(filaEnc);
            }
        }

        static int ObterTamanhoVetor()
        {
            int tam = 0;
            while (true)
            {
                Console.Write("\nInforme a capacidade máxima do vetor: ");
                if (int.TryParse(Console.ReadLine(), out tam) && tam > 0)
                {
                    break;
                }
                Console.WriteLine("Tamanho inválido! Digite um número inteiro maior que 0.");
            }
            return tam;
        }

        #endregion

        #region Menus Lineares/Estáticos em Vetor

        static void MenuListaLinear(Lista_Linear listaLin)
        {
            bool voltar = false;
            while (!voltar)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("             Menu: Lista Linear (Vetor)           ");
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Inserir no Início");
                Console.WriteLine("2. Inserir no Fim");
                Console.WriteLine("3. Inserir em determinada Posição");
                Console.WriteLine("4. Remover do Início");
                Console.WriteLine("5. Remover do Fim");
                Console.WriteLine("6. Remover de determinada Posição");
                Console.WriteLine("7. Mostrar Lista");
                Console.WriteLine("0. Voltar ao menu anterior");
                Console.WriteLine("==================================================");
                Console.Write("Escolha a opção: ");

                string opcao = Console.ReadLine() ?? "";

                switch (opcao)
                {
                    case "1":
                        Console.Write("\nDigite o valor para inserir no início: ");
                        if (int.TryParse(Console.ReadLine(), out int valIni))
                        {
                            if (listaLin.InserirInício(valIni)) Console.WriteLine("Inserido com sucesso!");
                            else Console.WriteLine("Erro: Vetor cheio!");
                        }
                        Pausar();
                        break;
                    case "2":
                        Console.Write("\nDigite o valor para inserir no fim: ");
                        if (int.TryParse(Console.ReadLine(), out int valFim))
                        {
                            if (listaLin.InserirFim(valFim)) Console.WriteLine("Inserido com sucesso!");
                            else Console.WriteLine("Erro: Vetor cheio!");
                        }
                        Pausar();
                        break;
                    case "3":
                        Console.Write("\nDigite o valor: ");
                        if (int.TryParse(Console.ReadLine(), out int val))
                        {
                            Console.Write("Digite o índice/posição: ");
                            if (int.TryParse(Console.ReadLine(), out int pos))
                            {
                                if (listaLin.InserirPos(val, pos)) Console.WriteLine("Inserido com sucesso!");
                                else Console.WriteLine("Posição inválida ou vetor cheio!");
                            }
                        }
                        Pausar();
                        break;
                    case "4":
                        if (listaLin.RemoverInício()) Console.WriteLine("\nRemovido do início com sucesso!");
                        else Console.WriteLine("\nO vetor está vazio! Não há como remover valores!");
                        Pausar();
                        break;
                    case "5":
                        if (listaLin.RemoverFim()) Console.WriteLine("\nRemovido do fim com sucesso!");
                        else Console.WriteLine("\nO vetor está vazio! Não há como remover valores!");
                        Pausar();
                        break;
                    case "6":
                        Console.Write("\nDigite o índice que deseja remover: ");
                        if (int.TryParse(Console.ReadLine(), out int posRem))
                        {
                            if (listaLin.RemoverPos(posRem)) Console.WriteLine($"O {posRem} foi removido com sucesso!");
                            else Console.WriteLine("O índice é inválido ou vetor vazio!");
                        }
                        Pausar();
                        break;
                    case "7":
                        listaLin.MostrarLista();
                        Pausar();
                        break;
                    case "0":
                        voltar = true;
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida!");
                        Pausar();
                        break;
                }
            }
        }

        static void MenuPilhaLinear(Pilha_Linear pilhaLin)
        {
            bool voltar = false;
            while (!voltar)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("             Menu: Pilha Linear (Vetor)           ");
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Inserir elemento (Empilhar)");
                Console.WriteLine("2. Retirar elemento (Desempilhar)");
                Console.WriteLine("3. Mostrar Pilha");
                Console.WriteLine("4. Limpar Pilha");
                Console.WriteLine("0. Voltar ao menu anterior");
                Console.WriteLine("==================================================");
                Console.Write("Escolha a opção: ");

                string opcao = Console.ReadLine() ?? "";

                switch (opcao)
                {
                    case "1":
                        Console.Write("\nDigite o valor para empilhar: ");
                        if (int.TryParse(Console.ReadLine(), out int val))
                        {
                            if (pilhaLin.Empilhar(val))
                                Console.WriteLine($"O {val} foi empilhado com sucesso!");
                            else
                                Console.WriteLine("Erro: Pilha cheia!");
                        }
                        Pausar();
                        break;

                    case "2":
                        if (pilhaLin.Desempilhar())
                            Console.WriteLine("\nPilha desempilhada com sucesso!");
                        else Console.WriteLine
                        ("\n Pilha vazia!");
                        Pausar();
                        break;

                    case "3":
                        pilhaLin.MostrarPilha();
                        Pausar();
                        break;

                    case "4":
                        pilhaLin.LimparPilha();
                        Console.WriteLine("\nA pilha foi limpa com sucesso!");
                        Pausar();
                        break;

                    case "0":
                        voltar = true;
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida!");
                        Pausar();
                        break;
                }
            }
        }

        static void MenuFilaLinear(Fila_Linear filaLin)
        {
            bool voltar = false;
            while (!voltar)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("             Menu: Fila Linear (Vetor)            ");
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Inserir no Fim (Enfileirar)");
                Console.WriteLine("2. Remover do Início (Desenfileirar)");
                Console.WriteLine("3. Mostrar Fila");
                Console.WriteLine("4. Limpar Fila");
                Console.WriteLine("0. Voltar ao menu anterior");
                Console.WriteLine("==================================================");
                Console.Write("Escolha a opção: ");

                string opcao = Console.ReadLine() ?? "";

                switch (opcao)
                {

                    case "1":
                        Console.Write("\nDigite o valor para enfileirar: ");
                        if (int.TryParse(Console.ReadLine(), out int val))
                        {
                            if (filaLin.InserirFila(val))
                                Console.WriteLine($"O {val} foi adicionado com sucesso!");
                            else
                                Console.WriteLine("Fila cheia! Não há como inserir mais valores!");
                        }
                        Pausar();
                        break;
                    case "2":
                        if (filaLin.RemoverFila())
                            Console.WriteLine("\nElemento removido com sucesso!");
                        else
                            Console.WriteLine("\nA fila já está vazia! Não há como remover elementos!");
                        Pausar();
                        break;
                    case "3":
                        filaLin.MostrarFila();
                        Pausar();
                        break;
                    case "4":
                        filaLin.LimparFila();
                        Pausar();
                        break;
                    case "0":
                        voltar = true;
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida!");
                        Pausar();
                        break;
                }
            }
        }

        #endregion

        #region Menus Dinâmicos/Encadeados

        static void MenuLista(Lista lista)
        {
            bool voltar = false;
            while (!voltar)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("                Menu: Lista Encadeada             ");
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Inserir no Início");
                Console.WriteLine("2. Inserir no Fim");
                Console.WriteLine("3. Inserir em determinada posição");
                Console.WriteLine("4. Preencher lista aleatoriamente");
                Console.WriteLine("5. Remover do Início");
                Console.WriteLine("6. Remover do Fim");
                Console.WriteLine("7. Remover determinado elemento");
                Console.WriteLine("8. Mostrar Lista");
                Console.WriteLine("9. Limpar Lista");
                Console.WriteLine("0. Voltar ao menu anterior");
                Console.WriteLine("==================================================");
                Console.Write("Escolha a opção: ");

                string opcao = Console.ReadLine() ?? "";

                switch (opcao)
                {
                    case "1":
                        Console.Write("\nDigite o número para inserir no início: ");
                        if (int.TryParse(Console.ReadLine(), out int valInicio))
                            lista.InserirInicioLista(valInicio);
                        Pausar();
                        break;
                    case "2":
                        Console.Write("\nDigite o número para inserir no fim: ");
                        if (int.TryParse(Console.ReadLine(), out int valFim))
                            lista.InserirFimLista(valFim);
                        Pausar();
                        break;
                    case "3":
                        Console.Write("\nDigite o número para inserir: ");
                        if (int.TryParse(Console.ReadLine(), out int valPos))
                        {
                            Console.Write("Digite a posição desejada: ");
                            if (int.TryParse(Console.ReadLine(), out int pos))
                                lista.InserirPosicaoLista(valPos, pos);
                        }
                        Pausar();
                        break;
                    case "4":
                        Console.Write("\nQuantos números deseja adicionar aleatoriamente? ");
                        if (int.TryParse(Console.ReadLine(), out int qtd) && qtd > 0)
                        {
                            Console.Write("Informe o limite superior randômico: ");
                            if (int.TryParse(Console.ReadLine(), out int sup) && sup > 0)
                                lista.PreencherListaRandomIni(qtd, sup);
                        }
                        Pausar();
                        break;
                    case "5":
                        Console.WriteLine();
                        lista.RemoverInicio();
                        Pausar();
                        break;
                    case "6":
                        Console.WriteLine();
                        lista.RemoverFim();
                        Pausar();
                        break;
                    case "7":
                        Console.Write("\nDigite o valor do elemento que deseja remover: ");
                        if (int.TryParse(Console.ReadLine(), out int valRem))
                            lista.RemoverElemento(valRem);
                        Pausar();
                        break;
                    case "8":
                        lista.MostrarLista();
                        Pausar();
                        break;
                    case "9":
                        Console.WriteLine();
                        lista.LimparLista();
                        Pausar();
                        break;
                    case "0":
                        voltar = true;
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida!");
                        Pausar();
                        break;
                }
            }
        }

        static void MenuPilha(Pilha pilha)
        {
            bool voltar = false;
            while (!voltar)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("                Menu: Pilha Encadeada             ");
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Inserir elemento (Empilhar)");
                Console.WriteLine("2. Retirar elemento (Desempilhar)");
                Console.WriteLine("3. Preencher pilha aleatoriamente");
                Console.WriteLine("4. Mostrar Pilha");
                Console.WriteLine("5. Limpar Pilha");
                Console.WriteLine("0. Voltar ao menu anterior");
                Console.WriteLine("==================================================");
                Console.Write("Escolha a opção: ");

                string opcao = Console.ReadLine() ?? "";

                switch (opcao)
                {
                    case "1":
                        Console.Write("\nDigite o valor a ser empilhado: ");
                        if (int.TryParse(Console.ReadLine(), out int val))
                            pilha.InserirElemPilha(val);
                        Pausar();
                        break;
                    case "2":
                        Console.WriteLine();
                        pilha.RetirarElemPilha();
                        Pausar();
                        break;
                    case "3":
                        int qtd = 0;
                        while (true)
                        {
                            Console.Write("\nQuantos números deseja adicionar aleatoriamente?  ");
                            if (int.TryParse(Console.ReadLine(), out qtd) && qtd > 0) break;
                            Console.WriteLine("Quantidade inválida!");
                        }
                        int sup = 0;
                        while (true)
                        {
                            Console.Write("Qual será o número máximo para o sorteio? ");
                            if (int.TryParse(Console.ReadLine(), out sup) && sup > 0) break;
                            Console.WriteLine("Valor inválido!");
                        }
                        pilha.PreencherPilhaRandom(qtd, sup);
                        Pausar();
                        break;
                    case "4":
                        pilha.MostrarPilha();
                        Pausar();
                        break;
                    case "5":
                        Console.WriteLine();
                        pilha.LimparPilha();
                        Pausar();
                        break;
                    case "0":
                        voltar = true;
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida!");
                        Pausar();
                        break;
                }
            }
        }

        static void MenuFila(Fila fila)
        {
            bool voltar = false;
            while (!voltar)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("                Menu: Fila Encadeada              ");
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Inserir na Fila (Enfileirar)");
                Console.WriteLine("2. Retirar da Fila (Desenfileirar)");
                Console.WriteLine("3. Preencher Fila aleatoriamente");
                Console.WriteLine("4. Mostrar Fila");
                Console.WriteLine("5. Limpar Fila");
                Console.WriteLine("0. Voltar ao menu anterior");
                Console.WriteLine("==================================================");
                Console.Write("Escolha a opção: ");

                string opcao = Console.ReadLine() ?? "";

                switch (opcao)
                {
                    case "1":
                        Console.Write("\nDigite o valor para enfileirar: ");
                        if (int.TryParse(Console.ReadLine(), out int val))
                            fila.InserirElemFila(val);
                        Pausar();
                        break;
                    case "2":
                        Console.WriteLine();
                        fila.RetirarElemFila();
                        Pausar();
                        break;
                    case "3":
                        int qtd = 0;
                        while (true)
                        {
                            Console.Write("\nQuantos números deseja adicionar aleatoriamente?  ");
                            if (int.TryParse(Console.ReadLine(), out qtd) && qtd > 0) break;
                            Console.WriteLine("Quantidade inválida!");
                        }
                        int sup = 0;
                        while (true)
                        {
                            Console.Write("Qual será o número máximo para o sorteio? ");
                            if (int.TryParse(Console.ReadLine(), out sup) && sup > 0) break;
                            Console.WriteLine("Valor inválido!");
                        }
                        fila.PreencherFilaRandom(qtd, sup);
                        Pausar();
                        break;
                    case "4":
                        fila.MostrarFila();
                        Pausar();
                        break;
                    case "5":
                        Console.WriteLine();
                        fila.LimparFila();
                        Pausar();
                        break;
                    case "0":
                        voltar = true;
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida!");
                        Pausar();
                        break;
                }
            }
        }

        #endregion

        static void Pausar() // Mensagem padrão para voltar ao menu 
        {
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

    }
}