using System;
using System.Globalization;

namespace AtividadeLogica.EstruturaSequencial
{
    class Principal
    {
        static void Main()
        {
            /*
            Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas,
            o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o 
            número e o salário do funcionário, com duas casas decimais.
            */

            System.Console.Write("NÚMERO: ");
            int numero = int.Parse(Console.ReadLine());
            System.Console.Write("HORAS TRABALHADAS: ");
            int horas = int.Parse(Console.ReadLine());
            System.Console.Write("VALOR POR HORA: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double salario = 0.0;

            double salario = horas * valor;

            System.Console.WriteLine("\nNúmero: {0}", numero);
            System.Console.WriteLine("Salário: R$ {0}", salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}