using System;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            int[] positivos = new int[10];
            int[] negativos = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite números para colocar na Array (10 números):");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
                if (myArray[i] < 0)
                {
                    negativos[i] = myArray[i];
                }
                else if (myArray[i] >= 0)
                {
                    positivos[i] = myArray[i];
                }
            }
            Console.WriteLine("Vetor com todos os números: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(myArray[i] +  " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Vetor com os números positivos: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(positivos[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Vetor com os números negativos: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(negativos[i] + " ");
            }
            Console.ReadKey();

            //Perguntar
        }
    }
}
