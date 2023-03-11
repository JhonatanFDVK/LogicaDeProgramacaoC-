using System;

namespace AtividadeLogica.EstruturaRepetitiva
{
    class Principal
    {
        static void Main()
        {
            /*
            Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X,
            um valor por linha, inclusive o X, se for o caso.
            */

            System.Console.Write("\nX: ");
            int x = int.Parse(Console.ReadLine());

            System.Console.WriteLine();

            for (int i = 0; i <= x; i++)
            {
                if (i % 2 == 1)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}