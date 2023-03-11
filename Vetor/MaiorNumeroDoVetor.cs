using System;
using System.Globalization;

namespace AtividadeLogica.Vetor
{
    class Principal
    {
        static void Main()
        {
            /*
            Faça um programa que leia N números reais e armazene-os em um vetor.
            Em seguida, mostrar na tela o maior número do vetor (supor não haver empates).
            Mostrar também a posição do maior elemento.
            */

            // Ler  um número que será o tamanho do vetor
            System.Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            // Cria um vetor com o tamanho N
            double[] vetor = new double[n];

            // Ler a quantidade de N numeros e os armazena no vetor
            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Número: ");
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            // Guarda o maior número do vetor
            double maiorNumero = 0.0;

            // Verifica qual o maior número do vetor
            foreach (double item in vetor)
            {
                if (item > maiorNumero)
                {
                    maiorNumero = item;
                }
            }

            // Verifica qual a posição em que o maior número do vetor está
            int posicaoDoMaiorNumero = Array.IndexOf(vetor, maiorNumero);

            // Exibe o maior número do vetor e a sua posição
            System.Console.WriteLine("\nMaior número do vetor: {0}", maiorNumero.ToString("F1", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Posição do maior número: {0}", posicaoDoMaiorNumero);
        }
    }
}