using System;

namespace AtividadeLogica.Matriz
{
    class Principal
    {
        static void Main(string[] args)
        {
            /*
            Ler um inteiro N e uma matriz quadrada de ordem N.
            Mostrar qual o maior elemento de cada linha.
            Suponha não haver empates.
            */

            System.Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    System.Console.Write("Número: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            System.Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                int maiorElemento = 0; // Guarda o maior valor de cada linha

                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] > maiorElemento)
                    {
                        maiorElemento = matriz[i, j]; 
                    }
                }

                System.Console.WriteLine("O MAIOR ELEMENTO DA LINHA {0} = {1} ", i + 1, maiorElemento);
            }
        }
    }
}