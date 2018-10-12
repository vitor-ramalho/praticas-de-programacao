using System;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior, menor, area;
            Console.WriteLine("Vamos calcular a área de um losango, primeiro, digite a diagonal maior!");
            maior = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Agora, digite a diagonal menor.");
            menor = Convert.ToInt32(Console.ReadLine());

            area = (maior * menor) / 2;

            Console.WriteLine("O valor da área é " + area + "!");


            Console.WriteLine("Aperte uma tecla para sair.");
            Console.ReadKey();
        }
    }
}
