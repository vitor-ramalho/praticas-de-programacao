using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite números para colocar na Array (10 números):");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Elementos pares:");
            for (int i = 0; i < 10; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    Console.Write("{0} ", myArray[i]);
                }
            }
            Console.WriteLine("");

            Console.WriteLine("Elementos ímpares:");
            for (int i = 0; i < 10; i++)
            {
                if (myArray[i] % 2 != 0 )
                {
                    Console.Write("{0} ", myArray[i]);
                }
            }

            Console.ReadKey();
        }
    }
}