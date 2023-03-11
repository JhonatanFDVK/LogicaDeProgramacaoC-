using System;
using System.Globalization;

namespace AtividadeLogica.EstruturaRepetitiva
{
    class Principal
    {
        static void Main()
        {
            /*
            Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir.
            Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal.
            Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o
            primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            peso 5.
            */

            System.Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            double[] media = new double[n];

            System.Console.WriteLine("\nDígite três valores reais.");
            
            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split();

                double primeiroValor = double.Parse(vet[0]);
                double segundoValor = double.Parse(vet[1]);
                double terceiroValor = double.Parse(vet[2]);

                int pesoPrimeiroValor = 2;
                int pesoSegundoValor = 3;
                int pesoTerceiroValor = 5;

                int somaDosPesos = pesoPrimeiroValor + pesoSegundoValor + pesoTerceiroValor;

                double A = pesoPrimeiroValor * primeiroValor + pesoSegundoValor * segundoValor + pesoTerceiroValor * terceiroValor;

                double mediaPonderada = A / somaDosPesos; ;

                media[i] = mediaPonderada;
            }

            System.Console.WriteLine("\nMédia ponderada.");

            foreach (double item in media)
            {
                System.Console.WriteLine(item.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}