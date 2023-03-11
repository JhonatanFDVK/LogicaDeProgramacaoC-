using System;

namespace AtividadeLogica.Vetor
{
    class Principal
    {
        static void Main()
        {
             /*
            Fazer um programa para ler um conjunto de N nomes de alunos,
            bem como as notas que eles tiraram no 1º e 2º semestres.
            Cada uma dessas informações deve ser armazenada em um vetor. 
            Depois, imprimir os nomes dos alunos aprovados, considerando
            aprovados aqueles cuja média das notas seja maior ou igual a seis.
            */

            System.Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            string[] alunos = new string[n];
            double[] notas = new double[2];
            string[] alunosAprovados = new String[n];

            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Nome, nota do 1° semestre, nota do 2° semestre: ");
                string[] vet = Console.ReadLine().Split();

                alunos[i] = vet[0];
                notas[0] = double.Parse(vet[1]);
                notas[1] = double.Parse(vet[2]);

                // Calcula a média das notas
                double media = (notas[0] + notas[1]) / 2;

               // Verifica se a média é maior ou igual a seis
                if (media >= 6.0)
                {
                    // Coloca no vetor os nomes dos alunos cujo a média é maior ou igual a seis
                    alunosAprovados[i] = alunos[i];
                }
            }

            System.Console.WriteLine("\nAlunos aprovados.\n");

            // Imprime todso os alunos que foram aprovados
            foreach (string item in alunosAprovados)
            {
                if (item != null)
                {
                    System.Console.WriteLine(item + ".");
                }
            }
        }
    }
}