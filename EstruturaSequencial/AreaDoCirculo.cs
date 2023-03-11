using System;
using System.Globalization;

namespace AtividadeLogica.EstruturaSequencial
{
    class Principal
    {
        static void Main()
        {
            /*
            Faça um programa para ler o valor do raio de um círculo, e depois mostrar o
            valor da área deste círculo com quatro casas decimais conforme exemplos.
            Considere o valor de π = 3.14159.
            */

            System.Console.Write("RAIO: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            const double PI = 3.14159;

            double areaDoCirculo = PI * (raio * raio);

            System.Console.WriteLine("\nÁREA = {0}", areaDoCirculo.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}