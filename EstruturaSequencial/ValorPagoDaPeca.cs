using System;
using System.Globalization;

namespace AtividadeLogica.EstruturaSequencial
{
    class Principal
    {
        static void Main()
        {
            /*
            Fazer um programa para ler o código de uma peça 1, o número de peças 1,
            o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2
            e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
            */

            System.Console.Write("\nCÓDIGO DA 1° PEÇA: ");
            int codigoPecaUm = int.Parse(Console.ReadLine());
            System.Console.Write("QUANTIDADE DA 1° PEÇA: ");
            int quantidadePecaUm = int.Parse(Console.ReadLine());
            System.Console.Write("VALOR DA 1° PEÇA: ");
            double valorPrimeiraPeca = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.Write("\nCÓDIGO DA 2° PEÇA: ");
            int codigoPecaDois = int.Parse(Console.ReadLine());
            System.Console.Write("QUANTIDADE DA 2° PEÇA: ");
            int quantidadePecaDois = int.Parse(Console.ReadLine());
            System.Console.Write("VALOR DA 2° PEÇA: ");
            double valorSegundaPeca = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorTotal = quantidadePecaUm * valorPrimeiraPeca + quantidadePecaDois * valorSegundaPeca;

            System.Console.Write("\nVALOR A PAGAR: R$ {0} ", valorTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}