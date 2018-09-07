using System;

namespace exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso;

            Console.WriteLine("Vamos fazer uns cálculos, digite o seu peso!");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Se você engordar 15%, voce terá " + (peso + (peso * 0.20)) + " quilos!");
            Console.WriteLine("Se você emagrecer 20%, voce terá " + (peso - (peso * 0.15)) + " quilos!");

            Console.WriteLine("Aperte uma tecla para sair.");
            Console.ReadKey();

        }
    }
}
