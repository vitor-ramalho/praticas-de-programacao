using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = {10, 10, 10, 10, 16, 16, 16, 17, 19, 20};
        int[] frequencia = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        int frequenciaModa = 0;
        int moda = 0;

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (numeros[j] == numeros[i])
                {
                    frequencia[i]++;
                }
            }
        }

        for (int i = 0; i < 10; i++)
        {
            if (frequencia[i] > frequenciaModa)
            {
                frequenciaModa = frequencia[i];
                moda = numeros[i];         
            }
        }

    Console.WriteLine(moda);
    }
}