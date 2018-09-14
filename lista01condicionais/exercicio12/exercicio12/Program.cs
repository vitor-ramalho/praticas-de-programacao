using System;

namespace exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int diarias;

            Console.WriteLine("Digite o número de diárias que você deseja.");
            diarias = Convert.ToInt32(Console.ReadLine());

            if (diarias < 15)
            {
                Console.WriteLine("O total a ser pago é: R$" + (diarias * 1.50));
            }
            else if (diarias == 15)
            {
                Console.WriteLine("O total a ser pago é: R$" + (diarias));
            }
            else if (diarias > 15)
            {
                Console.WriteLine("O total a ser pago é: R$" + (diarias * 0.50));
            }

            Console.WriteLine("Aperte uma tecla para sair.");
            Console.ReadKey();
        }
    }
}
