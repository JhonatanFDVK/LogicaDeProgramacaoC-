using System;

namespace AtividadeLogica.EstruturaSequencial
{
    class Principal
    {
        static void Main()
        {
            /*
            Fazer um programa para ler quatro valores inteiros A, B, C e D.
            A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C
            e D segundo a fórmula: DIFERENCA = (A * B - C * D).
            */

            System.Console.Write("\nA: ");
            int a = int.Parse(Console.ReadLine());
            System.Console.Write("B: ");
            int b = int.Parse(Console.ReadLine());
            System.Console.Write("C: ");
            int c = int.Parse(Console.ReadLine());
            System.Console.Write("D: ");
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b - c * d);

            System.Console.WriteLine("\nDIFERENÇA = {0}", diferenca);
        }
    }
}