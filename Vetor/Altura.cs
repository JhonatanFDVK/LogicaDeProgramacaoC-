using System;
using System.Globalization;

namespace AtividadeLogica.Vetor
{
    class Principal
    {
        static void Main()
        {
            /*
            Fazer um programa para ler um número inteiro N e a altura de N pessoas.
            Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas
            pessoas.
            */

            int n = int.Parse(Console.ReadLine());

            double[] vetor = new double[n];
            System.Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                System.Console.Write("ALTURA: ");
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;

            // Fazendo a soma de todas as alturas para calcular a média.
            foreach (double item in vetor)
            {
                soma += item;
            }

            double media = soma / n;

            System.Console.WriteLine("MÉDIA DE ALTURA: {0}", media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}