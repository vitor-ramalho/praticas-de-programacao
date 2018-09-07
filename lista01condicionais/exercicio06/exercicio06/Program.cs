using System;

namespace exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            double minimo, salario;

            Console.WriteLine("Digite o seu salário, vamos calcular quantos salários mínimos você ganha!");
            salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Agora, digite o valor do salário mínimo atual.");
            minimo = float.Parse(Console.ReadLine());

            Console.WriteLine("Você ganha " + (salario / minimo) + " salários mínimos.");


            Console.WriteLine("Aperte uma tecla para sair.");
            Console.ReadKey();
        }
    }
}
