using System;

namespace exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 3];
            int valor;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite os números que deseja incluir na Array (três linhas, três números em cada): ");
                    myArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Digite um valor: ");
            valor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Os valores da Array multiplicados pelo valor digitado são: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    myArray[i, j] = myArray[i, j] * valor;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }       
    }
}
