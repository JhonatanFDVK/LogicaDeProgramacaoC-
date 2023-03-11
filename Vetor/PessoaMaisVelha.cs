using System;

namespace AtividadeLogica.Vetor
{
    class Principal
    {
        static void Main()
        {
            /*
            Fazer um programa para ler um conjunto de nomes de pessoas e suas respectivas idades.
            Depois, mostrar na tela o nome
            da pessoa mais velha.
            */

            // Um número N que será digitado pelo usuário
            System.Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            // Dois vetores com tamanho N
            string[] nomes = new string[n];
            int[] idades = new int[n];

            // Adiciona valores nos vetores
            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Nome e idade: ");
                string[] vet = Console.ReadLine().Split();

                nomes[i] = vet[0];
                idades[i] = int.Parse(vet[1]);
            }

            // Guarda a maior idade do vetor "idades"
            int maiorIdade = 0;

            // Calcula a maior idade do vetor "idades"
            foreach (int item in idades)
            {
                if (item > maiorIdade)
                {
                    maiorIdade = item;
                }
            }

            // Descobre a posição no vetor em que a idade mais velha está
            int indice = Array.IndexOf(idades, maiorIdade);
            // Armazena o nome do vetor "nomes" que está na posição do indice
            string nome = nomes[indice];

            System.Console.WriteLine("\nPessoa mais velha: " + nome);
        }
    }
}