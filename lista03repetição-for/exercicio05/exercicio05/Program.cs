using System;

namespace exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, maiorNota, menorNota;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite a sua primeira nota:");
                nota1 = Convert.ToDouble(Console.ReadLine());

                maiorNota = nota1;
                menorNota = nota1;

                Console.WriteLine("Digite a sua segunda nota:");
                nota2 = Convert.ToDouble(Console.ReadLine());

                if (maiorNota > nota2 && menorNota > nota2)
                {
                    menorNota = nota2;
                }
                else if (maiorNota > nota2 && menorNota < nota2)
                {

                }
                else if (maiorNota < nota2 && menorNota > nota2)
                {
                    maiorNota = nota2;
                    menorNota = nota2;
                }
                else if (maiorNota < nota2 && menorNota < nota2)
                {
                    maiorNota = nota2;
                }

                Console.WriteLine("Digite a sua terceira nota:");
                nota3 = Convert.ToDouble(Console.ReadLine());

                if (maiorNota > nota3 && menorNota > nota3)
                {
                    menorNota = nota3;
                }
                else if (maiorNota > nota3 && menorNota < nota3)
                {

                }
                else if (maiorNota < nota3 && menorNota > nota3)
                {
                    maiorNota = nota3;
                    menorNota = nota3;
                }
                else if (maiorNota < nota3 && menorNota < nota3)
                {
                    maiorNota = nota3;
                }

                Console.WriteLine("A sua maior nota foi: " + maiorNota);
                Console.WriteLine("A sua menor nota foi: " + menorNota);
            }
        }
    }
}
