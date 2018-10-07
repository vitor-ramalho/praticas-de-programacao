using System;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 3];
            int operacao, linha, coluna;
            int soma = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite os números que deseja incluir na Array (três linhas, três números em cada): ");
                    myArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Agora digite 1 para fazer uma operação com coluna e 2 para fazer uma operação com linha:");
            operacao = Convert.ToInt32(Console.ReadLine());
            if ( operacao == 2)
            {
                Console.WriteLine("Informe o número da linha (0, 1 ou 2):");
                linha = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                for (int k = 0; k < 3; k++)
                {
                    Console.Write(myArray[linha, k]);
                    Console.Write("");
                    soma = soma + (myArray[linha, k]);
                }
                Console.WriteLine("");
                Console.WriteLine("A soma dos números da linha escolhida é igual a {0}", soma);
            }
            else if ( operacao == 1)
            {
                Console.WriteLine("Informe o número da coluna (0, 1 ou 2): ");
                coluna = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                for (int l = 0; l < 3; l++)
                {
                    Console.WriteLine(myArray[l, coluna]);
                    soma = soma + myArray[l, coluna];
                }
                Console.WriteLine("");
                Console.WriteLine("A soma dos números da linha escolhida é igual a {0}", soma);
            }
            Console.ReadKey();
        }
    }
}