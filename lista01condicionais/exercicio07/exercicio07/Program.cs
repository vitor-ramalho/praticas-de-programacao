using System;

namespace exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade;

            Console.WriteLine("Vamos calcular quantos dias você ja viveu, digite sua idade!");
            idade = double.Parse(Console.ReadLine());

            Console.WriteLine("Você viveu, aproximadamente, " + (idade * 365) + " dias!");

            Console.WriteLine("Aperte uma tecla para sair.");
            Console.ReadKey();
        }
    }
}
