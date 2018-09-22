using System;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacidade, peso, i;

            capacidade = 0;
            i = 0;

            while(capacidade < 800)
            {
                Console.WriteLine("Digite o seu peso: ");
                peso = Convert.ToInt32(Console.ReadLine());

                capacidade = capacidade + peso;
                i++;

                Console.WriteLine("O peso total das pessoas presentes é de " + capacidade + "kgs.");
                Console.WriteLine("O número de pessoas é de: " + i + " pessoas.");
            }
            Console.WriteLine("A capacidade de 800 quilos foi esgotada.");

            Console.WriteLine("Pressione uma tecla para sair.");
            Console.ReadKey();
        }
    }
}
