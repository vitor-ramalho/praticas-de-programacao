using System;

namespace exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.WriteLine("Informe o primeiro número.");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo número.");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o terceiro número.");
            z = Convert.ToInt32(Console.ReadLine());

            if (y + z < x || x + y < z || z + x < y)
            {
                Console.WriteLine("Infelizmente esses números não formam um triângulo.");
            }
            else
            {
                Console.WriteLine("Esses números formam um triângulo.");
            }

            Console.WriteLine("Aperte uma tecla para sair.");
            Console.ReadKey();
        }
    }
}
