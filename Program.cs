using System;

namespace moduloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            *Atividade
            * Crie um programa que receba dois valores e calcule a soma desses valores.
            * Ao final exiba o resultado no console.
            */

            #region
            Console.WriteLine("Digite 1 para INICIAR o programa ou 0 para SAIR.");
            int opcao = int.Parse(Console.ReadLine());
            while (opcao != 0)
            {
                int a, b;
                Console.WriteLine("Informe 2 números para somá-los.");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                int resultado = Soma(a, b);
                Console.WriteLine("A soma é: " + resultado);
                Console.WriteLine("Se deseja sair, digite 0, senão 1.");
                opcao = int.Parse(Console.ReadLine());
            }
            #endregion
        }

        static int Soma(int a, int b)
        {
            return a + b;
        }
    }
}
