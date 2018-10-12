using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            int soma = 0;
            int media = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite números para colocar na Array (10 números):");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
                soma = myArray[i] + soma;
                media = soma / 10;
            }
            Console.WriteLine("A média é {0}.", media);

            Console.WriteLine("Elementos acima da média:");
            for (int i = 0; i < 10; i++)
            {
                if (myArray[i] > media)
                {
                    Console.Write("{0} ", myArray[i]);
                }
            }
            Console.WriteLine("");

            Console.WriteLine("Elementos abaixo da média:");
            for (int i = 0; i < 10; i++)
            {
                if (myArray[i] < media)
                {
                    Console.Write("{0} ", myArray[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
