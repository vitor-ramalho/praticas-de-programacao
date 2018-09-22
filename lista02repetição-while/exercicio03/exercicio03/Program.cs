using System;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, homensSelec, mulheresSelec, i;
            char sexo;
            double peso;

            i = 0;
            homensSelec = 0;
            mulheresSelec = 0;

            while (i < 10)
            {
                Console.WriteLine("Digite seu sexo (H ou M): ");
                sexo = Convert.ToChar(Console.ReadLine());

                if (sexo == 'H')
                {
                    Console.WriteLine("Informe sua idade: ");
                    idade = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe o seu peso: ");
                    peso = Convert.ToDouble(Console.ReadLine());

                    if ((idade <= 30 || idade >= 20) && (peso > 60))
                    {
                        homensSelec++;
                        i++;
                    }
                    else
                    {
                        homensSelec = homensSelec + 0;
                        i++;
                    }
                }
                else if (sexo == 'M')
                {
                    Console.WriteLine("Informe sua idade: ");
                    idade = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe o seu peso: ");
                    peso = Convert.ToDouble(Console.ReadLine());

                    if ((idade > 40) && (peso < 70))
                    {
                        mulheresSelec++;
                        i++;
                    }
                    else
                    {
                        mulheresSelec = mulheresSelec + 0;
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine("Informe um sexo válido (H ou M).");
                }
                Console.WriteLine("O número de homens é com as características é: " + homensSelec);
                Console.WriteLine("O número de mulheres com as características é: " + mulheresSelec);
            }
            Console.WriteLine("Pressione uma tecla para sair.");
            Console.ReadKey();
            }
        }
    }

