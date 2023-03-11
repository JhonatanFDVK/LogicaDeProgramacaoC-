using System;

namespace AtividadeLogica.EstruturaRepetitiva
{
    class Principal
    {
        static void Main()
        {
            /*
            Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
            essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
            */

            System.Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            int dentroDoIntervalo = 0;
            int foraDoIntervalo = 0;

            for (int i = 0; i < n; i++)
            {
                System.Console.Write("X: ");
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    dentroDoIntervalo++;
                }
                else
                {
                    foraDoIntervalo++;
                }
            }

            System.Console.WriteLine("\n" + dentroDoIntervalo + " in");
            System.Console.WriteLine(foraDoIntervalo + " out");

        }
    }
}