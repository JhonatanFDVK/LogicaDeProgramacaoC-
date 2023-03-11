using System;
using System.Globalization;

namespace AtividadeLogica.EstruturaCondicional
{
    class Principal
    {
        static void Main()
        {
            /*
            Com base na tabela de preços ao lado, faça
            um programa que leia o código de um item e a
            quantidade deste item. A seguir, calcule e
            mostre o valor da conta a pagar.
            */

            System.Console.WriteLine
            (
            "\n1 Cachorro Quente R$ 4.00\n" +
            "2 X - Salada R$ 4.50\n" +
            "3 X - Bacon R$ 5.00\n" +
            "4 Torrada Simples R$ 2.00\n" +
            "5 Refrigerante R$ 1.50"
            );

            double cachorroQuente = 4.00;
            double xSalada = 4.50;
            double xBacon = 5.00;
            double torradaSimples = 2.00;
            double refrigerante = 1.50;

            System.Console.Write("\nCÓDIGO: ");
            int codigo = int.Parse(Console.ReadLine());
            System.Console.Write("QUANTIDADE: ");
            int quantidade = int.Parse(Console.ReadLine());

            double valorTotal = 0.0;

            switch (codigo)
            {
                case 1:
                    {
                        valorTotal = quantidade * cachorroQuente;
                        break;
                    }
                case 2:
                    {
                        valorTotal = quantidade * xSalada;
                        break;
                    }
                case 3:
                    {
                        valorTotal = quantidade * xBacon;
                        break;
                    }
                case 4:
                    {
                        valorTotal = quantidade * torradaSimples;
                        break;
                    }
                case 5:
                    {
                        valorTotal = quantidade * refrigerante;
                        break;
                    }
                default:
                    {
                        System.Console.WriteLine("\nCÓDIGO INVÁLIDO.");
                        break;
                    }
            }

            System.Console.WriteLine("\nTotal: R$ {0}", valorTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}