using System;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo;
            int idade;
            int mulheresSelec = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Digite a sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Agora digite seu sexo (M ou F): ");
                sexo = Console.ReadLine();
                sexo = sexo.ToUpper();

                if (sexo == "F")
                {
                    if (idade >= 20 && idade <= 40)
                    {
                        mulheresSelec++;
                    }
                }
                else if (sexo == "M")
                {

                }
                else
                {
                    Console.WriteLine("Por favor, tente novamente com sexo e idade válidos.");
                    break;
                }
                Console.WriteLine("Número de mulheres entre 20 e 40 anos: " + mulheresSelec);
            }
        }
    }
}
