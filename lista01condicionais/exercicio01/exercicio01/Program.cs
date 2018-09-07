using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Digite um número para saber sua tabuada: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(x + " * 1 = " + x * 1);
            Console.WriteLine(x + " * 2 = " + x * 2);
            Console.WriteLine(x + " * 3 = " + x * 3);
            Console.WriteLine(x + " * 4 = " + x * 4);
            Console.WriteLine(x + " * 5 = " + x * 5);
            Console.WriteLine(x + " * 6 = " + x * 6);
            Console.WriteLine(x + " * 7 = " + x * 7);
            Console.WriteLine(x + " * 8 = " + x * 8);
            Console.WriteLine(x + " * 9 = " + x * 9);

            Console.WriteLine("Aperte uma tecla para sair.");
            Console.ReadKey();
        }
    }
}
