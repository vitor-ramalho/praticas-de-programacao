

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] numeros = new int [12, 12];
        Random randm = new Random();
        for (int i = 0; i < 1; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                numeros[i, j] = randm.Next(1,9);
                Console.Write(numeros[i, j] + " ");               
            }
            Console.WriteLine("");
        }

        int[,] numeros2 = numeros;

        Console.WriteLine("");
        Console.WriteLine("");

        for (int i = 0; i < 12; i++)
        {
	        for(int j = 0; j < 12; j++)
	        {
		        numeros[i, i] = numeros2[i, 11 - i];
                numeros[i, 11 - i] = numeros2[i, i];
	        }
        }

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                Console.Write(numeros[i, j] + " ");               
            }
            Console.WriteLine(" ");
        }
    }
}
