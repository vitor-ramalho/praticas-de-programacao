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
                Console.WriteLine("Digite os números para a primeira coluna (4 números): ");
                myArray[i, 0] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(myArray[i, 0]);
            }
            Console.ReadKey();
        }
    }
}