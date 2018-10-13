using System;

class Program
{
    static void Main(string[] args)
    {
        int horas1, horas2, minutos1, minutos2, segundos1, segundos2;
        Console.WriteLine("Digite o primeiro horario (horas, minutos, segundos):");
        Console.WriteLine("Horas:");
        horas1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Minutos:");
        minutos1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Segundos:");
        segundos1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo horario (horas, minutos, segundos):");
        Console.WriteLine("Horas:");
        horas2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Minutos:");
        minutos2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Segundos:");
        segundos2 = Convert.ToInt32(Console.ReadLine());

        Diferenca(horas1, minutos1, segundos1, horas2, minutos2, segundos2);
    }
    static public void Diferenca(int horas1, int minutos1, int segundos1, int horas2, int minutos2, int segundos2)
    {
        int diferencaHoras = Math.Abs(horas1 - horas2);
        int diferencaMinutos = Math.Abs(minutos1 - minutos2);
        int diferencaSegundos = Math.Abs(segundos1 - segundos2);
        Console.WriteLine("A diferença entre as horas é: {0}:{1}:{2}", diferencaHoras, diferencaMinutos, diferencaSegundos);          
    }   
}