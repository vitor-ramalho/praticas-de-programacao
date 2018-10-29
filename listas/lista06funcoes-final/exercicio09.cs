using System;
class Program
{
    static void Main(string[] args)
    {
        int [,] MyArray = new int[10,10];
        Random randm = new Random();
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                //Console.WriteLine("Informe os dados da {0} linha da matriz (10, 10):", i);
                //MyArray[i, j] = Convert.ToInt32(Console.ReadLine());
                MyArray[i, j] = randm.Next(1,9);               
            }
        }
        ExibirArray(MyArray);
        int soma = SomaAbaixoDaDiagonalPrincipal(MyArray);
        Console.WriteLine("A soma dos números abaixo da diagonal principal é {0}.", soma);
    }
    static int SomaAbaixoDaDiagonalPrincipal(int[,] MyArray)
    {
        int[] ArraySoma = new int[10];
        int soma = 0;
        for (int i = 1; i < 10; i++)
        {
            int somaLinha = 0;

            for (int j = 0; (j < (10 - (10 - i))); j++)
            {
                somaLinha = somaLinha + MyArray[i, j];
            }
            Console.WriteLine(somaLinha);
            soma = soma + somaLinha;
        }
        Console.WriteLine("");
        return soma;
    }
    static public void ExibirArray(int[,] MyArray)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(MyArray[i, j] + " ");
            }
            Console.WriteLine(" ");
        }
    }
}