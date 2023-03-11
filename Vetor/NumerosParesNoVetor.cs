using System;

namespace AtividadeLogica.Vetor
{
    class Principal
    {
        static void Main()
        {
            /*
            Faça um programa que leia N números inteiros e armazene-os em um vetor.
            Em seguida, mostre na tela:
            - todos os números pares
            - a quantidade de números pares
            */

            System.Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            int[] vetor = new int[n];

            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            int quantidadeNumerosPares = 0;

            System.Console.WriteLine("\nTodos os números pares.");

            foreach (int item in vetor)
            {
                if (item % 2 == 0)
                {
                    System.Console.Write(item + " ");
                    quantidadeNumerosPares++;
                }
            }

            System.Console.WriteLine("\nQuantidade de números pares.");
            System.Console.WriteLine(quantidadeNumerosPares);
        }
    }
}