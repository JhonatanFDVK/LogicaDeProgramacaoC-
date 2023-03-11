using System;
using System.Globalization;

namespace AtividadeLogica.Vetor
{
    class Principal
    {
        static void Main()
        {
            /*
            Fazer um programa para ler um vetor de N números inteiros.
            Em seguida, mostrar na tela a média aritmética somente
            dos números pares lidos. 
            */

            System.Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            int[] vetor = new int[n];

            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            int soma = 0;
            int contadorDePares = 0;

            foreach (int item in vetor)
            {
                if (item % 2 == 0)
                {
                    soma += item;
                    contadorDePares++;
                }
            }

            int media = soma / contadorDePares;

            System.Console.Write("\nMédia dos números pares: {0}", media.ToString("F1",
            CultureInfo.InvariantCulture));
        }
    }
}