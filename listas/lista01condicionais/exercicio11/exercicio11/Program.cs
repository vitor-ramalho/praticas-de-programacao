using System;

namespace exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, peso, imc;

            Console.WriteLine("Vamos calcular seu IMC, primeiro, digite sua altura em metros!");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora, digite seu peso.");
            peso = double.Parse(Console.ReadLine());

            imc = (peso / (altura * altura));

            if (imc < 20)
            {
                Console.WriteLine("Seu IMC é " + imc + " e você está abaixo do peso.");
            }
            else if (20 < imc & imc < 25)
            {
                Console.WriteLine("Seu IMC é " + imc + " e você está no peso normal.");
            }
            else if (25 < imc & imc < 30)
            {
                Console.WriteLine("Seu IMC é " + imc + " e você está com sobre peso.");
            }
            else if (30 < imc & imc < 40)
            {
                Console.WriteLine("Seu IMC é " + imc + " e você está obeso.");
            }
            else if (imc >= 40)
            {
                Console.WriteLine("Seu IMC é " + imc + " e você está com obesidade mórbida.");
            }
            else
            {
                Console.WriteLine("Por favor, tente novamente com um número válido");
            }

            Console.WriteLine("Aperte uma tecla para sair.");
            Console.ReadKey();


        }
    }
}
