using System;

namespace AtividadeLogica.Matriz
{
    class Principal
    {
        static void Main(string[] args)
        {
            /*
            Ler dois números M e N, e depois ler uma matriz MxN de números inteiros, conforme exemplo.
            Em seguida, mostrar na tela somente os números negativos da matriz.
            */

            System.Console.Write("M: "); // Quantidade linhas
            int m = int.Parse(Console.ReadLine());
            System.Console.Write("N: "); // Quantidade de colunas
            int n = int.Parse(Console.ReadLine());

            // Matriz que tem a quantidade m de linhas e a quantidade n de colunas
            int[,] matriz = new int[m, n];
            System.Console.WriteLine();

            //  Adicionando valores a matriz
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    System.Console.Write("Número: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            System.Console.WriteLine("\nVALORES NEGATIVOS.");

            // Imprime somente os números negativos da matriz
            foreach (int item in matriz)
            {
                if (item < 0)
                {
                    System.Console.Write(item + " ");
                }
            }
        }
    }
}