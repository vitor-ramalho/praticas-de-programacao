using System;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, nota5, media;

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Digite a sua primeira nota: ");
                nota1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a sua segunda nota: ");
                nota2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a sua terceira nota: ");
                nota3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a sua quarta nota: ");
                nota4 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a sua quinta nota: ");
                nota5 = Convert.ToDouble(Console.ReadLine());

                media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

                Console.WriteLine("A sua média é " + media);
            }
        }
    }
}
