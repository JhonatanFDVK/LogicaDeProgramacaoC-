using System;
using System.Globalization;

namespace AtividadeLogica.Matriz
{
    class Principal
    {
        static void Main()
        {
            /*
            Ler uma matriz quadrada de ordem N, contendo números reais. Em seguida, fazer as seguintes ações:
            a) calcular e imprimir a soma de todos os elementos positivos da matriz.
            b) fazer a leitura do índice de uma linha da matriz e, daí, imprimir todos os elementos desta linha.
            c) fazer a leitura do índice de uma coluna da matriz e, daí, imprimir todos os elementos desta coluna.
            d) imprimir os elementos da diagonal principal da matriz.
            e) alterar a matriz elevando ao quadrado todos os números negativos da mesma. Em seguida imprimir a matriz alterada.
            */

            System.Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            double[,] matriz = new double[n, n];

            // Aicionando elementos na matriz

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    System.Console.Write("Número: ");
                    matriz[i, j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            }

            System.Console.WriteLine();

            // Calcula a soma de todos os elementos positivos da matriz.
            
            double soma = 0.0;

            foreach (double item in matriz)
            {
                if (item >= 0)
                {
                    soma += item;
                }
            }

            System.Console.Write("SOMA DOS POSITIVOS: {0}\n", soma.ToString("F1", CultureInfo.InvariantCulture));

            // Imprime todos os elementos da linha do indice que for escolhido.

            System.Console.Write("\nLINHA ESCOLHIDA: ");
            int indice = int.Parse(Console.ReadLine());

            System.Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                System.Console.Write(matriz[indice, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            System.Console.WriteLine();

            // Imprime todos os elementos da coluna do indice que for escolhido.

            System.Console.Write("\nCOLUNA ESCOLHIDA: ");
            indice = int.Parse(Console.ReadLine());

            System.Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine(matriz[i, indice].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            // Imprime os elementos da diagonal principal da matriz.

            System.Console.WriteLine("\nDIAGONAL PRINCIPAL.\n");

            int coluna = 0;

            for (int i = 0; i < n; i++)
            {
                System.Console.Write(matriz[i, coluna].ToString("F1", CultureInfo.InvariantCulture) + " ");
                coluna++;
            }

            System.Console.WriteLine();

            // Altera a matriz elevando todos os números negativos ao quadrado.

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        matriz[i, j] = matriz[i, j] * matriz[i, j];
                    }
                }
            }

            System.Console.WriteLine();

            // Imprime a matriz alterada.

            System.Console.WriteLine("MATRIZ ALTERADA.");

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine();

                for (int j = 0; j < n; j++)
                {
                    System.Console.Write(matriz[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
            }

            System.Console.WriteLine();
        }
    }
}