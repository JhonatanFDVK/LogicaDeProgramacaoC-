using System;

namespace AtividadeLogica.EstruturaRepetitiva
{
    class Principal
    {
        static void Main()
        {
            /*
            Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
            que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
            mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            exemplo.
            */

            System.Console.WriteLine("1.Álcool\n2.Gasolina\n3.Diesel\n4.Fim\n");

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int codigo = 0;

            while (codigo != 4)
            {
                System.Console.Write("Informe um código: ");
                codigo = int.Parse(Console.ReadLine());

                while (codigo < 1 || codigo > 4)
                {
                    System.Console.WriteLine("\nCódigo inválido.");
                    System.Console.Write("Informe um código: ");
                    codigo = int.Parse(Console.ReadLine());
                }

                switch (codigo)
                {
                    case 1:
                        {
                            alcool++;
                            break;
                        }
                    case 2:
                        {
                            gasolina++;
                            break;
                        }
                    case 3:
                        {
                            diesel++;
                            break;
                        }
                }
            }

            System.Console.WriteLine("\nMUITO OBRIGADO!");
            System.Console.WriteLine("Alcool: " + alcool);
            System.Console.WriteLine("Gasolina: " + gasolina);
            System.Console.WriteLine("Diesel: " + diesel);
        }
    }
}