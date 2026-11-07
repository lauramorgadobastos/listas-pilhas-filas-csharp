using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Estrutura adaptada de Lista para Fila

namespace EstruturasLineares
{
    class Fila_Linear
    {
        int[] Vetor;
        int Pos;

        public Fila_Linear(int Tam)
        {
            Pos = 0;
            Vetor = new int[Tam];
        }

        public bool InserirFila(int valor) // Insere no final
        {
            if (Pos < Vetor.Length)
            {
                Vetor[Pos] = valor;
                Pos++;
                return true;
            }
            return false; // Fila cheia
        }

        public bool RemoverFila() // Remover do início
        {
            if (Pos > 0)
            {
                // Remove do início e arrasta todos os elementos uma posição para trás
                for (int i = 0; i < Pos - 1; i++)
                {
                    Vetor[i] = Vetor[i + 1];
                }
                Pos--;
                return true;
            }
            return false; // Fila vazia
        }

        public void MostrarFila()
        {
            Console.Clear();
            Console.WriteLine("--- FILA LINEAR (VETOR) ---");  // Mostrar todos os elementos...
            for (int i = 0; i < Pos; i++)
            {
                Console.Write($"{Vetor[i],6}");
            }


        }

        public void LimparFila()
        {
            if (Pos == 0)
            {
                Console.WriteLine("A fila já está vazia!");
            }
            else
            {
                Pos = 0;
                Console.WriteLine("A fila foi limpa com sucesso!");
            }
        }
    }
}
