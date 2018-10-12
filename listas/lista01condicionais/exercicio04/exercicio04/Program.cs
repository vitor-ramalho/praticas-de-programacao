using System;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;

            Console.WriteLine("Vamos fazer uma conversão, digite um número em graus Celsius!");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = (celsius * 1.8) + 32;

            Console.WriteLine("O seu número em Fahrenheit é " + fahrenheit + "!");

            Console.WriteLine("Aperte uma tecla para sair.");
            Console.ReadKey();
        }
    }
}
