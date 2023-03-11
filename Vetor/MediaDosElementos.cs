using System;
using System.Globalization;

namespace AtividadeLogica.Vetor
{
    class Principal
    {
        static void Main()
        {
            /*
            Fazer um programa para ler um vetor de N números reais.
            Em seguida, mostrar na tela a média aritmética de todos elementos.
            Depois mostrar todos os elementos do vetor que estejam abaixo da média.
            */

            System.Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            double[] vetor = new double[n];

            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Número: ");
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;

            foreach (double item in vetor)
            {
                soma += item;
            }

            double media = soma / n;

            System.Console.WriteLine("\nMédia dos elementos no vetor: {0}", media.ToString("F3",
            CultureInfo.InvariantCulture));

            System.Console.WriteLine("Elementos do vetor abaixo da média.");

            foreach (double item in vetor)
            {
                if (item < media)
                {
                    System.Console.Write(item.ToString("F1", CultureInfo.InvariantCulture) + "  ");
                }
            }
        }
    }
}