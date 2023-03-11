using System;

namespace AtividadeLogica.Matriz
{
    class Principal
    {
        static void Main(string[] args)
        {
            /*
            Ler um número N e depois uma matriz quadrada NxN com números inteiros.
            Depois, mostrar na tela a soma dos elementos de cada linha da matriz.
            */

            System.Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            // Matriz com n quantidade de linhas e colunas
            int[,] matriz = new int[n, n];
            System.Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                // Quebra uma linha toda vez que uma nova linha começa
                System.Console.WriteLine();

                for (int j = 0; j < n; j++)
                {
                    // Adiciona valores na matriz
                    System.Console.Write("Número: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            System.Console.WriteLine("\nSOMA.");

            for (int i = 0; i < n; i++)
            {
                int soma = 0;

                for (int j = 0; j < n; j++)
                {
                    soma += matriz[i, j]; // Acumula a soma dos valores da linha
                }

                System.Console.WriteLine(soma);
            }
        }
    }
}