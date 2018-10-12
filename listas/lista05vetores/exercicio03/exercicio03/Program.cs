using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            int maior = 0;
            int menor = 99999;
            int indexMaior = 0;
            int indexMenor = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite números para colocar na Array (10 números):");
                myArray[i] = Convert.ToInt32(Console.ReadLine());

                if (myArray[i] > maior && myArray[i] < menor)
                {
                    maior = myArray[i];
                    menor = myArray[i];
                    indexMaior = i;
                    indexMenor = i;
                }
                else if (myArray[i] > maior)
                {
                    maior = myArray[i];
                    indexMaior = i;
                }
                else if (myArray[i] < menor)
                {
                    menor = myArray[i];
                    indexMenor = i;
                }
            }
            Console.WriteLine("O maior número da Array é {0}.", maior);
            Console.WriteLine("O index do maior número é {0}.", indexMaior);
            Console.WriteLine("O menor número da Array é {0}.", menor);
            Console.WriteLine("O index do menor número é {0}.", indexMenor);
            Console.ReadKey();
        }
    }
}