using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite os números para a primeira linha (4 números): ");
                myArray[0,i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write(myArray[0, i]);
            }
            Console.ReadKey();
        }
    }
}
