using System;

namespace exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] myArray = new int[10];
            int [] myArray2 = new int[5];
            int numeros = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite números para colocar na primeira Array (10 números):");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Agora, informe mais cinco números:");
                myArray2[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (myArray[i] == myArray2[j])
                    {
                        numeros++;
                    }
                }
            }
            Console.WriteLine("Os números digitados podem ser encontrados {0} vezes no vetor.", numeros);
        }
    }
}