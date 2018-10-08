using System;

namespace exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[4, 4];
            int[] arrayMaior = new int[4];
            for (int i = 0; i < 4; i++)
            {
                int maiorNumero = -9999;
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Digite os números que deseja incluir na Array (quatro linhas, quatro números em cada): ");
                    myArray[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (myArray[i, j] > maiorNumero)
                    {
                        maiorNumero = myArray[i, j];
                    }
                }
                arrayMaior[i] = maiorNumero;
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Vetor novo com o maior elemento de cada linha:");

            for (int i = 0; i < 4; i++)
            {
                Console.Write((arrayMaior[i]) + " ");
            }
            Console.ReadKey();
        }
    }
}