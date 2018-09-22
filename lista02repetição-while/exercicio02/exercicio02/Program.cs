using System;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int matricula, nota1, nota2, nota3, media;

            matricula = 0;
     
            while (matricula >= 0)
            {
                Console.WriteLine("Digite sua matrícula: ");
                matricula = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a primeira nota: ");
                nota1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a primeira nota: ");
                nota2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a primeira nota: ");
                nota3 = Convert.ToInt32(Console.ReadLine());

                media = (nota1 + nota2 + nota3) / 3;

                if (media >= 70)
                {
                    Console.WriteLine("Você foi aprovado.");
                }
                else if (media < 60)
                {
                    Console.WriteLine("Você foi reprovado.");
                }
                else if (media <= 60 && media < 70)
                {
                    Console.WriteLine("Você vai para o exame.");
                }
            }
        }
    }
}
