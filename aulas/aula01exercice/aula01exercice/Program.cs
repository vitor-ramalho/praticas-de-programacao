using System;

namespace aula01exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, operacao;
            Console.WriteLine("Digite o valor de X");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de Y");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual operação você deseja fazer? Tecle: 1 -> +, 2-> -, 3 -> *, 4 -> / ");
            operacao = Convert.ToInt32(Console.ReadLine());
            
            if (operacao ==  1)
            {
                z = x + y;
                Console.WriteLine("O valor da operação é: " + z);
            }

            if (operacao == 2)
            {
                z = x - y;
                Console.WriteLine("O valor da operação é: " + z);
            }

            if (operacao == 3)
            {
                z = x * y;
                Console.WriteLine("O valor da operação é: " + z);
            }
            
            if (operacao == 4)
            {
                z = x / y;
                Console.WriteLine("O valor da operação é: " + z);
            }

            else
            {
                Console.WriteLine("Por favor, tecle um número válido.");
            }
        }
    }
}
