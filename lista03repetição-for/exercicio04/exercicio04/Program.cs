using System;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int menorIdade = 1000;
            int maiorIdade = 0;

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Digite a sua idade");
                idade = Convert.ToInt32(Console.ReadLine());

                if (idade > maiorIdade && idade < menorIdade)
                {
                    maiorIdade = idade;
                    menorIdade = idade;
                }
                else if (idade < maiorIdade && idade < menorIdade)
                {
                    menorIdade = idade;
                }
                else if (idade > maiorIdade && idade > menorIdade)
                {
                    maiorIdade = idade;
                }
                else {

                }
                Console.WriteLine("A maior idade até o momento é: " + maiorIdade + " anos.");
                Console.WriteLine("A menor idade até o momento é: " + menorIdade + " anos. ");
            }
        }
    }
}
