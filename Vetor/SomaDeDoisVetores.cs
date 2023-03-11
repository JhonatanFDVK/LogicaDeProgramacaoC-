using System;

namespace AtividadeLogica.Vetor
{
    class Principal
    {
        static void Main()
        {
            /*
            Faça um programa para ler dois vetores A e B, contendo N elementos cada.
            Em seguida, gere um terceiro vetor C onde cada elemento de C é a soma dos elementos
            correspondentes de A e B. Imprima o vetor C gerado
            */

            System.Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            int[] A = new int[n];
            int[] B = new int[n];

            System.Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Número: ");
                A[i] = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Número: ");
                B[i] = int.Parse(Console.ReadLine());
            }

            int[] C = new int[n];

            for (int i = 0; i < n; i++)
            {
                C[i] = A[i] + B[i];
            }

            System.Console.WriteLine();

            foreach (int item in C)
            {
                System.Console.Write(item + " ");
            }
        }
    }
}