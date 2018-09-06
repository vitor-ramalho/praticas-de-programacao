using System;

namespace aula02atividade01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            int[] numbers = new int[3];


            Console.WriteLine("Digite o valor de X");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de Y");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de Z");
            z = Convert.ToInt32(Console.ReadLine());

            numbers[0] = x;
            numbers[1] = y;
            numbers[2] = z;
            
            if (x > y && x > z)
            {
                Console.WriteLine("O maior número é X: " + x);
            }
            if (y > x & y > z)
            {
                Console.WriteLine("O maior número é Y: " + y);
            }
            if (z > x & z > y)
            {
                Console.WriteLine("O maior número é Z: " + z);
            }

            Array.Sort(numbers);
            Console.WriteLine("Ordem decrescente:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Aperte uma tecla para sair.");
            Console.ReadKey();
        }
    }
}
