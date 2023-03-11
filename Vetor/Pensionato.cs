using System;

namespace AtividadeLogica.Vetor
{
    class Quarto
    {
        public string Nome;
        public string Email;
        public int Quarto_;

        public static int QuantidadeDeQuartos(int quantidadeDeQuartos)
        {   // O loop se repetirá enquanto N for menor que 1 ou maior que 10. Porque só há 10 quartos disponiveis para aluguel.
            while (quantidadeDeQuartos < 1 || quantidadeDeQuartos > 10)
            {
                System.Console.WriteLine("\nHá apenas 10 quartos disponiveis.");
                System.Console.Write("\nDígite a quantidade de quartos para alugar (1, 10): ");
                quantidadeDeQuartos = int.Parse(Console.ReadLine());
            }
            return quantidadeDeQuartos--;
        }
    }
    class Principal
    {
        static void Main()
        {
            /*
            A dona de um pensionato possui dez quartos para alugar para estudantes,
            sendo esses quartos identificados pelos números 0 a 9.
            Quando um estudante deseja alugar um quarto, deve-se registrar o nome
            e email deste estudante.
            Fazer um programa que inicie com todos os dez quartos vazios, e depois
            leia uma quantidade N representando o número de estudantes que vão
            alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
            N estudantes. Para cada registro de aluguel, informar o nome e email do
            estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
            que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
            um relatório de todas ocupações do pensionato, por ordem de quarto,
            conforme exemplo.
            */

            Quarto[] quarto = new Quarto[10];

            System.Console.Write("Dígite a quantidade de quartos para alugar (1, 10): ");
            int n = int.Parse(Console.ReadLine());

            int quantidadeDeQuartos = Quarto.QuantidadeDeQuartos(n);

            for (int i = 0; i < quantidadeDeQuartos; i++)
            {
                System.Console.Write("\nNome, Email e Quarto (1, 10): ");
                string[] vet = Console.ReadLine().Split();
                // Armazena o número do quarto escolhido.
                int numeroDoQuarto = int.Parse(vet[2]);
                //Se o quarto escolhido não existir (só há quartos de 1 a 10), faça:
                while (numeroDoQuarto < 1 || numeroDoQuarto > 10)
                {
                    System.Console.WriteLine("\nEsse quarto não existe.");
                    System.Console.Write("Quarto (1, 10): ");
                    numeroDoQuarto = int.Parse(Console.ReadLine());
                }
                // Descobre o indice que o número do quarto representa.
                numeroDoQuarto = numeroDoQuarto - 1;
                
                // Se o quarto já tiver sido escolhido, faça:
                while (quarto[numeroDoQuarto] != null)
                {
                    System.Console.WriteLine("\nEsse quarto não está mais disponivel.");
                    System.Console.Write("Quarto (1, 10): ");
                    numeroDoQuarto = int.Parse(Console.ReadLine());
                    // Se o quarto escolhido não existir (só há quartos de 1 a 10), faça:
                    while (numeroDoQuarto < 1 || numeroDoQuarto > 10)
                    {
                        System.Console.WriteLine("\nEsse quarto não existe.");
                        System.Console.Write("Quarto (1, 10): ");
                        numeroDoQuarto = int.Parse(Console.ReadLine());
                    }
                    // Indice que o número do quarto representa.
                    numeroDoQuarto = numeroDoQuarto - 1;
                }
                // Cria um objeto em um vetor do tipo Quarto, e armazena as informações em um ou mais indice do vetor.
                quarto[numeroDoQuarto] = new Quarto()
                {
                    Nome = vet[0],
                    Email = vet[1],
                    Quarto_ = numeroDoQuarto
                };

            }

            System.Console.WriteLine("\nQuartos ocupados: ");

            for (int i = 0; i < 10; i++)
            {
                // Se o quarto no indice I não for vazio, então imprima suas informações.
                if (quarto[i] != null)
                {
                    System.Console.WriteLine((i + 1) + ": " + quarto[i].Nome + ", " + quarto[i].Email);
                }
            }
        }
    }
}