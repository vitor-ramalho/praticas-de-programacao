using System;

namespace exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Informe o código do produto (1 a 15)");
            x = Convert.ToInt32(Console.ReadLine());

            if (x == 1)
            {
                Console.WriteLine("Alimento não perecível");
            }
            else if (x < 5 & x > 1)
            {
                Console.WriteLine("Alimento perecível");
            }
            else if (x < 7 & x > 4)
            {
                Console.WriteLine("Vestuário");
            }
            else if (x == 7)
            {
                Console.WriteLine("Higine pessoal");
            }
            else if (x < 16 & x > 7)
            {
                Console.WriteLine("Limpeza e Utensílios Domésticos");
            }
            else
            {
                Console.WriteLine("Número Inválido, tente novamente.");
            }

            Console.WriteLine("Aperte uma tecla para sair.");
            Console.ReadKey();

        }
    }
}
