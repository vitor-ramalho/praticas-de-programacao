using System;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 5];
            int numerosSelec = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Digite os números que deseja incluir na Array (três linhas, cinco números em cada): ");
                    myArray[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (myArray[i, j] >= 15 && myArray[i, j] <= 20)
                    {
                        numerosSelec++;
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("A quantidade de números entre 15 e 20 dentro da Array é {0}", numerosSelec);
            Console.ReadKey();
        }
    }
}
