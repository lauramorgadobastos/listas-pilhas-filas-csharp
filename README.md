<div align="center">

#  Listas, Pilhas e Filas em C# (Estática e Dinâmica)

![C#](https://img.shields.io/badge/C%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![.NET 8](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Status](https://img.shields.io/badge/Status-Concluído-success?style=for-the-badge)
![PUC Minas](https://img.shields.io/badge/PUC%20Minas-003366?style=for-the-badge&logo=edu&logoColor=white)



Repositório acadêmico desenvolvido em **C# (.NET 8)** para a disciplina de Estrutura de Dados da **PUC Minas**. O objetivo principal deste projeto é consolidar o estudo prático de estruturas lineares, comparando duas abordagens fundamentais de alocação de memória: **Alocação Estática (baseada em vetores de tamanho fixo)** e **Alocação Dinâmica (baseada em nós encadeados por ponteiros/referências)**.

</div>

---

##  Objetivo do Projeto

Compreender o comportamento interno e a manipulação de ponteiros em estruturas de dados fundamentais da Computação, exercitando operações de inserção, remoção, percorrimento, geração automatizada de massa de dados e gerenciamento de capacidade em tempo de execução através de um menu interativo no console.

---

## Opções e Funcionalidades Implementadas no Menu

O sistema é centralizado em um menu principal (`Program.cs`) que direciona para submenus específicos de cada estrutura de dados:

### 1.  Listas
* **Lista Linear (Estática em Vetor):**
  - Inserção no início, no fim ou em posição específica (com deslocamento automático/*shifting* de elementos).
  - Remoção do início, do fim ou de índice específico.
  - Exibição dos dados alocados no vetor.
* **Lista Encadeada (Dinâmica):**
  - Inserção flexível no início, fim ou posição arbitrária.
  - **Preenchimento Randômico:** Utilização da classe `Random` (`System.Random`) para gerar e inserir automaticamente uma quantidade personalizada de elementos até um limite superior definido pelo usuário.
  - Remoção por início, fim ou busca de valor específico.
  - Exibição visual dos nós encadeados (`[Valor] -> [Valor] -> null`) e contagem dinâmica de tamanho.
  - Limpeza total da lista.

### 2. Pilhas (LIFO - Last In, First Out)
* **Pilha Linear (Estática em Vetor):**
  - Operação de Empilhar (*Push*) com controle de estouro de capacidade (*overflow*).
  - Operação de Desempilhar (*Pop*) com validação de pilha vazia (*underflow*).
  - Exibição e limpeza da pilha baseada em índice de topo.
* **Pilha Encadeada (Dinâmica):**
  - Empilhamento dinâmico sem limite pré-definido de tamanho.
  - Retirada de elementos do topo (*Topo*).
  - **Preenchimento Randômico:** Rotina automatizada que utiliza a classe `Random` para empilhar múltiplos valores aleatórios sequencialmente, facilitando testes rápidos de comportamento da pilha.
  - Exibição estruturada do topo para a base.

### 3.  Filas (FIFO - First In, First Out)
* **Fila Linear (Estática em Vetor):**
  - Enfileiramento (*Enqueue*) de novos elementos no final.
  - Desenfileiramento (*Dequeue*) no início com realocação dos elementos restantes.
  - Visualização sequencial e limpeza de dados.
* **Fila Encadeada (Dinâmica):**
  - Controle dinâmico com ponteiros diretos para o `Início` e o `Fim` da fila.
  - Enfileiramento e desenfileiramento otimizados.
  - **Preenchimento Randômico:** Método que utiliza `Random` para popular a fila de forma ágil, simulando a chegada dinâmica de elementos em cenários de teste de carga.

##  Métodos de Preenchimento Randômico (`Random`)

Para otimizar os testes de inserção e evitar o preenchimento manual elemento por elemento nas estruturas dinâmicas, o sistema implementa rotinas baseadas na classe `System.Random`. 

O usuário interage informando dois parâmetros principais:
1. **Quantidade de elementos:** Quantos números deseja sortear e inserir.
2. **Limite superior (`sup`):** O valor máximo permitido para os números sorteados (gerando números de `1` até `sup`).

Esses métodos percorrem um laço de repetição (`for`), instanciando e encadeando os novos nós de forma imediata na estrutura correspondente.

---

##  Estrutura do Repositório

```text
├── src/
│   ├── Models/
│   │   ├── Filas/
│   │   │   ├── Fila.cs          # Fila Dinâmica (Encadeada)
│   │   │   └── FilaLinear.cs    # Fila Estática (Vetor)
│   │   ├── Listas/
│   │   │   ├── Lista.cs         # Lista Dinâmica (Encadeada)
│   │   │   └── ListaLinear.cs   # Lista Estática (Vetor)
│   │   ├── Pilhas/
│   │   │   ├── Pilha.cs         # Pilha Dinâmica (Encadeada)
│   │   │   └── PilhaLinear.cs   # Pilha Estática (Vetor)
│   │   └── Elemento.cs          # Classe Nó para suporte aos encadeamentos
│   ├── AED - Atividade.csproj   # Arquivo de projeto .NET 8
│   └── Program.cs               # Menu principal e submenus de controle
├── .gitignore
└── README.md
```

---

## Como Executar

1. Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/) instalado na sua máquina.
2.  Clone este repositório:
   
   ```bash
   git clone https://github.com/lauramorgadobastos/listas-pilhas-filas-csharp.git
   
   ```

3. No terminal entre na pasta

 ```bash
  cd .\listas-pilhas-filas-csharp/src
   ```

4. Comando

```bash
   dotnet run   
   ```

5. Navegue pelo Menu Principal:
Digite o número correspondente a Lista, Pilha ou Fila deseja testar ou 0 para encerrar o programa.

---

## Sobre Mim

Desenvolvido por *Laura Morgado Bastos Gomes*  
Estudante de *Sistemas de Informação - PUC Minas*. 

### Conecte-se comigo

Você pode me encontrar nos canais abaixo:


[![Linkedin](https://img.shields.io/badge/LinkedIn-4C1D95?style=for-the-badge&logo=linkedin&logoColor=fff)](https://www.linkedin.com/in/laura-morgado-bastos?)
[![GitHub](https://img.shields.io/badge/GitHub-4C1D95?style=for-the-badge&logo=github&logoColor=fff)](https://github.com/lauramorgadobastos) 
[![Email](https://img.shields.io/badge/Email-4C1D95?style=for-the-badge&logo=gmail&logoColor=fff)](mailto:laura.bastosmorgado27@gmail.com)

---

##  Licença 
Este repositório não possui uma licença específica definida, pois tem caráter estritamente educacional e acadêmico para a disciplina de Algoritmos e Estrutura de Dados. 

---

<div align="center">
  <sub>Desenvolvido por <b>Laura Morgado</b>.</sub>
</div>

