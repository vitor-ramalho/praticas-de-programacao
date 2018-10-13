using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b, c;
        Console.WriteLine("Digite o valor de A.");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o valor de B.");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o valor de C.");
        c = Convert.ToInt32(Console.ReadLine());
        
        int[] MyArray = VetorOrdenado(a, b, c);

        Console.WriteLine("O menor número é {0}.", MyArray[0]);
        Console.WriteLine("O maior número é: {0}.", MyArray[2]);
    }
    public static int[] VetorOrdenado(int a, int b, int c)
    {
        int[] MyArray = new int[3];
        MyArray[0] = a;
        MyArray[1] = b;
        MyArray[2] = c;
        Array.Sort(MyArray);
        return MyArray;
    } 
}