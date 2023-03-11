using System;
using System.Globalization;

namespace AtividadeLogica.Vetor
{
    class Produto
    {
        public string Nome;
        public double Preco;
    }
    class Principal
    {
        static void Main()
        {
            /*
            Fazer um programa para ler um número inteiro N e os dados (nome e
            preço) de N Produtos. Armazene os N produtos em um vetor. Em
            seguida, mostrar o preço médio dos produtos.
            */

            System.Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] produto = new Produto[n];

            System.Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                produto[i] = new Produto
                {
                    Nome = nome,
                    Preco = preco
                };
            }

            double soma = 0.0;
            // Soma todos os preços
            foreach (Produto item in produto)
            {
                soma += item.Preco;
            }
            // Calcula o preço médio.
            double precoMedio = soma / n;

            System.Console.WriteLine("\nPreço médio: R${0} ", precoMedio.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}