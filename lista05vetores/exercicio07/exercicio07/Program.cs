using System;

namespace exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            int[] myArray2 = new int[10];
            int[] multiplicacao = new int[10];
            int[] divisao = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite números para colocar na primeira Array (10 números):");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite números para colocar na segunda Array (10 números):");
                myArray2[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                multiplicacao[i] = myArray[i] * myArray2[i];
                divisao[i] = myArray[i] / myArray2[i];
            }
            Console.WriteLine("Vetor 1:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Vetor 2:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(myArray2[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Vetor com as multiplicações:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(multiplicacao[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Vetor com as divisões:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(divisao[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
