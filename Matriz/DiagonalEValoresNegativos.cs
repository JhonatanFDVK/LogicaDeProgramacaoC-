using System;

namespace Matriz
{
    class Principal
    {
        static void Main()
        {
            /*
            Fazer um programa para ler um número inteiro N e uma matriz de ordem N
            contendo N números inteiros. Em seguida, mostrar a diagonal principal
            e a quantidade de valores negativos da matriz.
            */

            System.Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    System.Console.Write("N: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int qtdValoresNegativos = 0;

            foreach (int item in matriz)
            {
                if (item < 0)
                {
                    qtdValoresNegativos++;
                }
            }

            System.Console.Write("Diagonal principal: ");

            int linha = 0;

            for (int i = 0; i < n; i++)
            {
                System.Console.Write(matriz[linha, i] + " ");
                linha++;
            }

            System.Console.WriteLine("\nQuantidade de valores negativos na matriz: " + qtdValoresNegativos);

        }
    }
}