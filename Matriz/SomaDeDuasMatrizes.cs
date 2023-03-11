using System;

namespace AtividadeLogica.Matriz
{
    class Principal
    {
        static void Main()
        {
            /*
            Fazer um programa para ler duas matrizes de números inteiros A e B,
            contendo de M linhas e N colunas cada. Depois, gerar uma terceira matriz C
            onde cada elemento desta é a soma dos elementos correspondentes das matrizes originais.
            Imprimir na tela a matriz gerada.
            */

            System.Console.Write("Linhas: ");
            int m = int.Parse(Console.ReadLine());
            System.Console.Write("Colunas: ");
            int n = int.Parse(Console.ReadLine());

            int[,] a = new int[m, n];
            int[,] b = new int[m, n];

            System.Console.WriteLine();
            System.Console.WriteLine("1° matriz.");

            // Adiciona valores a matriz A.
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    System.Console.Write("Número: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine("2° matriz.");

            // Adiciona valores a matriz B.
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    System.Console.Write("Número: ");
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[,] c = new int[m, n];
            
            // Soma os elementos dos indices que são iguais e adiciona na matriz C.
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int soma = a[i, j] + b[i, j];
                    c[i, j] = soma;
                }
            }

            System.Console.WriteLine();

            // Imprime a matriz C.
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    System.Console.Write(c[i, j] + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}