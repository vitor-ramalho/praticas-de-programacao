using System;

namespace exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int media, num1, num2, num3, num4, num5, dif1, dif2, dif3, dif4, dif5;

            Console.WriteLine("Digite o primeiro número:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o quarto número:");
            num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o quinto número:");
            num5 = Convert.ToInt32(Console.ReadLine());

            media = (num1 + num2 + num3 + num4 + num5) / 5;

            Console.WriteLine("A média é: " + media);

            dif1 = Math.Abs(num1 - media);
            dif2 = Math.Abs(num2 - media);
            dif3 = Math.Abs(num3 - media);
            dif4 = Math.Abs(num4 - media);
            dif5 = Math.Abs(num5 - media);

            if (dif1 < dif2 && dif1 <dif3 && dif1 < dif4 && dif1 < dif5)
            {
                Console.WriteLine("O número mais próximo da média é: " + num1);
            }
            else if (dif2 < dif1 && dif2 < dif3 && dif2 < dif4 && dif2 < dif5)
            {
                Console.WriteLine("O número mais próximo da média é: " + num2);
            }
            else if (dif3 < dif1 && dif3 < dif2 && dif3 < dif4 && dif3 < dif5)
            {
                Console.WriteLine("O número mais próximo da média é: " + num3);
            }
            else if (dif4 < dif1 && dif4 < dif2 && dif4 < dif3 && dif4 < dif5)
            {
                Console.WriteLine("O número mais próximo da média é: " + num4);
            }
            else if (dif5 < dif1 && dif5 < dif2 && dif5 < dif3 && dif5 < dif4)
            {
                Console.WriteLine("O número mais próximo da média é: " + num5);
            }
            else
            {
                Console.WriteLine("Tente novamente");
            }

            Console.WriteLine("Aperte uma tecla para sair.");
            Console.ReadKey();
        }
    }
}
