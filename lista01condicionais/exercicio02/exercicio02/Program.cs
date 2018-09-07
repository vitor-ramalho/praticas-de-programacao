using System;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Digite um número!");
            x = Convert.ToInt32(Console.ReadLine());
            x = -(x);

            Console.WriteLine("Agora seu número é " + x + "!");

            Console.WriteLine("Aperte uma tecla para sair.");
            Console.ReadKey();

        }
    }
}
