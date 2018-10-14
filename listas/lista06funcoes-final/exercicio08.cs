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
        int soma = SomaDiagonalPrincipal(MyArray);
        Console.WriteLine("A soma dos números da diagonal principal é {0}.", soma);
    }
    static int SomaDiagonalPrincipal(int[,] MyArray)
    {
        int[] ArraySoma = new int[10];
        int soma = 0;
        for (int i = 0; i < 10; i++)
        {
            ArraySoma[i] = MyArray[i, i];
        }
        for (int i = 0; i < 10; i++)
        {
            soma = soma + ArraySoma[i];
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