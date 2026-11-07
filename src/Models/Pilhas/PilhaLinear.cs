using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Estrutura adaptada de Lista para Pilha
namespace EstruturasLineares
{
    class Pilha_Linear
    {
        int Topo;
        int[] Vetor;   // Vetor de Dados

        public Pilha_Linear(int Tam)
        {
            Vetor = new int[Tam];
            Topo = 0;
        }

        public bool Empilhar(int valor)  // Empilhar: Insere no topo
        {
            if (Topo < Vetor.Length)
            {
                Vetor[Topo] = valor;
                Topo++;
                return true;
            }
            return false; // Pilha cheia 
        }

        public bool Desempilhar() // Desempilhar: Remove do topo
        {
            if (Topo > 0)
            {
                Topo--;
                return true;
            }
            return false; // Pilha vazia 
        }

        public void MostrarPilha() // Exibir Pilha
        {
            Console.Clear();

            if (Topo == 0)
            {
                Console.WriteLine("A pilha está vazia!");
            }
            else
            {
                Console.WriteLine("--- PILHA (Topo) ---");
                for (int i = Topo - 1; i >= 0; i--)
                {
                    Console.WriteLine($"{Vetor[i],6}");
                }
            }
        }
        public void LimparPilha() // Limpa a pilha
        {
            Topo = 0;
        }
    }
}