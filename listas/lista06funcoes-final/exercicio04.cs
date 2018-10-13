using System;

class Program
{
    static void Main(string[] args)
    {
        int horas, minutos, segundos;
        Console.WriteLine("Digite o total de horas:");
        horas = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o total de minutos:");
        minutos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o total de segundos:");
        segundos = Convert.ToInt32(Console.ReadLine());

        int totalSegundos = Segundos(horas, minutos, segundos);

        Console.WriteLine("O total de segundos no horário é {0}.", totalSegundos);
    }
    static int Segundos(int horas, int minutos, int segundos)
    {
        int totalSegundos = segundos + (minutos * 60) + (horas * 60 * 60);
        return totalSegundos;
    }
}