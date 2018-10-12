using System;
class Program
{
    static void Main(string[] args)
    {
        int numeroDigitado;

        Console.WriteLine("Digite um número:");
        numeroDigitado = Convert.ToInt32(Console.ReadLine());
        int primo = CheckPrimo(numeroDigitado);
        if (primo == 1)
        {
            Console.WriteLine("O número é primo");
        }
        else if (primo == 0)
        {
            Console.WriteLine("O número não é primo");
        }
    }
    public static int CheckPrimo(int numero)
    {
        int div = 0;
        
        for (int i = 1; i < numero; i++)
        {
            if (numero % i == 0)
            {
                div++;
            }
        }
        if (div <= 2)
        {
            return 1; // numero primo
        }
        else
        {
            return 0; // numero não primo
        }
    }
}