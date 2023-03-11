using System;
using System.Globalization;

namespace AtividadeLogica.Vetor
{
    class Principal
    {
        static void Main()
        {
            /*
            Tem-se um conjunto de dados contendo a altura e o sexo (M, F) de N pessoas.
            Fazer um programa que calcule e escreva:
            a maior e a menor altura do grupo
            a média de altura das mulheres
            o número de homens
            */

            System.Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            string[] sexo = new string[n];
            double[] altura = new double[n];

            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Altura e sexo (M / F): ");
                string[] vet = Console.ReadLine().Split();

                altura[i] = double.Parse(vet[0]);
                sexo[i] = vet[1];

                /*Operação que servirá para calcular a média de mulheres
                if (sexo[i] == "F")
                {
                    soma += altura[i];
                    contador++;
                }
                */
            }

            double soma = 0.0;
            int contador = 0;

            foreach (string item in sexo)
            {
                if (item == "F")
                {
                    // Operação que servirá para calcular a média de mulheres
                    int indice = Array.IndexOf(sexo, item);
                    soma += altura[indice];
                    contador++;
                }
            }

            // Calcula a média de mulheres
            double mediaAlturaMulheres = soma / contador;

            //Descobre a menor altura
            double menorAltura = 999.0;

            foreach (double item in altura)
            {
                if (item < menorAltura)
                {
                    menorAltura = item;
                }
            }

            //Descobre a maior altura
            double maiorAltura = 0.0;

            foreach (double item in altura)
            {
                if (item > maiorAltura)
                {
                    maiorAltura = item;
                }
            }

            // Descobre a quantidade de homens
            int quantidadeHomens = 0;

            foreach (string item in sexo)
            {
                if (item == "M")
                {
                    quantidadeHomens++;
                }
            }

            System.Console.WriteLine("\nMenor altura: " + menorAltura.ToString("F2",
            CultureInfo.InvariantCulture));
            System.Console.WriteLine("Maior altura: " + maiorAltura.ToString("F2",
            CultureInfo.InvariantCulture));
            System.Console.WriteLine("Média de altura das mulheres: " + mediaAlturaMulheres.ToString("F2",
            CultureInfo.InvariantCulture));
            System.Console.WriteLine("Número de homens: " + quantidadeHomens);
        }
    }
}