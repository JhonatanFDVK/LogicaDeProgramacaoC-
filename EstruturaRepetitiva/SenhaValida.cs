using System;

namespace AtividadeLogica.EstruturaRepetitiva
{
    class Principal
    {
        static void Main()
        {
            /*
            Escreva um programa que repita a leitura de uma senha até que ela seja válida.
            Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida".
            Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido"
            e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
            */

            int senhaCorreta = 2002;
            int senhaDigitada;

            do
            {
                System.Console.Write("\nSENHA ");
                senhaDigitada = int.Parse(Console.ReadLine());

                if (senhaDigitada != senhaCorreta)
                {
                    System.Console.WriteLine("Senha invalida.");
                }

            } while (senhaDigitada != senhaCorreta);

            System.Console.WriteLine("\nAcesso Permitido.");

        }
    }
}
