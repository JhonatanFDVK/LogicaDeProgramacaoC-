using System;

namespace AtividadeLogica.Matriz
{
    class Principal
    {
        static void Main()
        {
            /*
            Ler um inteiro N e uma matriz quadrada de ordem N.
            Mostrar a soma dos elementos acima da diagonal principal.
            */

            System.Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    // Adiciona um valor na linha i coluna j
                    System.Console.Write("Número: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int soma = 0;
            int coluna = 0;

            for (int i = 0; i < n; i++) // i representa a linha
            {
                soma += matriz[i, coluna];
                coluna++;
            }

            System.Console.WriteLine("\nSOMA DOS ELEMENTOS DA DIAGONAL PRINCIPAL = {0}", soma);
        }
    }
}