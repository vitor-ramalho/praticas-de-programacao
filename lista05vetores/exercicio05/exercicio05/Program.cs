using System;

namespace exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            bool procurarNumero = true;
            bool numeroEncontrado;
            int numero, opcao;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite números para colocar na Array (10 números):");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            while(procurarNumero == true)
            {
                Console.WriteLine("Digite um número para verificarmos se ele está no Vetor:");
                numero = Convert.ToInt32(Console.ReadLine());
                numeroEncontrado = false;
                for (int i = 0; i < 10; i++)
                {
                    if (myArray[i] == numero)
                    {
                        numeroEncontrado = true;
                        Console.WriteLine("O número está na Array, na posição {0}!", i);
                    }
                }
                if (numeroEncontrado == false)
                {
                    Console.WriteLine("O número não existe na Array.");
                }
                Console.WriteLine("Deseja encontrar outro número? 1 - Sim, 2 - Não: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao == 1)
                {
                    procurarNumero = true;
                }
                else
                {
                    procurarNumero = false;
                }
            }
            Console.ReadKey();
        }
    }
}
