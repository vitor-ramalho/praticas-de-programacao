using System;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[2, 3];
            int maiorNumero = 0;
            int menorNumero = 100000;
            string posicaoMenor = "";
            string posicaoMaior = "";

            for (int i = 0; i < 2; i++)
            { 
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite os números da primeira linha (3 numeros) e segunda linha (3 numeros): ");
                    myArray[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (myArray[i, j] < menorNumero && myArray[i, j] > maiorNumero)
                    {
                        maiorNumero = myArray[i, j];
                        menorNumero = myArray[i, j];
                        posicaoMaior = Convert.ToString("Linha " + i + ", Coluna " + j);
                        posicaoMenor = Convert.ToString("Linha " + i + ", Coluna " + j);
                    }
                    else if (myArray[i, j] > maiorNumero) {
                        maiorNumero = myArray[i, j];
                        posicaoMaior = Convert.ToString( "Linha " + i + ", Coluna " + j );
                    }
                    else if (myArray[i, j] < menorNumero)
                    {
                        menorNumero = myArray[i, j];
                        posicaoMenor = Convert.ToString( "Linha " + i + ", Coluna " + j );
                    }

                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("O maior número da Array é {0}", maiorNumero);
            Console.WriteLine("A posição do maior número é: {0}", posicaoMaior);
            Console.WriteLine("O menor número da Array é {0}", menorNumero);
            Console.WriteLine("A posição do menor número é {0}", posicaoMenor);
            
            Console.ReadKey();
        }
    }
}
