using System;

namespace AtividadeLogica.EstruturaSequencial
{
    class Principal
    {
        static void Main()
        {
            /*
            Faça um programa para ler dois valores inteiros, e depois mostrar na tela
            a soma desses números com uma mensagem explicativa, conforme exemplos.
            */

            int soma = 0;

            System.Console.Write("Valor: ");
            int valor = int.Parse(Console.ReadLine());

            soma += valor;

            System.Console.Write("Valor: ");
            valor = int.Parse(Console.ReadLine());

            soma += valor;

            System.Console.Write("\nSOMA = {0}", soma);
        }
    }
}