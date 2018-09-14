using System;

namespace exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            char sexo;

            Console.WriteLine("Digite sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Agora digite o seu sexo (M ou F):");
            sexo = Convert.ToChar(Console.ReadLine());

            if (sexo == 'M')
            {
                if (idade <= 15)
                {
                    Console.WriteLine("O total da sua mensalidade é R$: 60,00");
                }
                else if (idade < 19 && idade > 15)
                {
                    Console.WriteLine("O total da sua mensalidade é R$: 75,00");
                }
                else if (idade < 31 && idade > 18)
                {
                    Console.WriteLine("O total da sua mensalidade é: R$ 90,00");
                }
                else if (idade < 41 && idade > 30)
                {
                    Console.WriteLine("O total da sua mensalidade é: R$ 85,00");
                }
                else if (idade > 40)
                {
                    Console.WriteLine("O total da sua mensalidade é: R$ 80,00");
                }
                else
                {
                    Console.WriteLine("Tente novamente.");
                }
            }
            else if (sexo == 'F')
            {
                if (idade < 19)
                {
                    Console.WriteLine("O total da sua mensalidade é: R$60,00");
                }
                else if (idade > 18 && idade < 26)
                {
                    Console.WriteLine("O total da sua mensalidade é: R$90,00");
                }
                else if (idade > 25 && idade < 41)
                {
                    Console.WriteLine("O total da sua mensalidade é: R$85,00");
                }
                else if (idade > 40)
                {
                    Console.WriteLine("O total da sua mensalidade é: R$80,00");
                }
                else
                {
                    Console.WriteLine("Tente novamente.");
                }
            }

            Console.WriteLine("Aperte uma tecla para sair.");
            Console.ReadKey();
        }
    }
}
