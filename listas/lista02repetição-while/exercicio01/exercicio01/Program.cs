using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int salario, filhos, mediaSalario, mediaFilhos, contador, totalSalario, totalFilhos;
            filhos = 0;
            salario = 0;
            totalSalario = 0;
            totalFilhos = 0;
            contador = 0;
            mediaSalario = 0;
            mediaFilhos = 0;

            while (salario >= 0)
            {
                Console.WriteLine("Digite seu salário");
                salario = Convert.ToInt32(Console.ReadLine());

                if (salario >= 0)
                {
                    totalSalario = totalSalario + salario;
                    
                    Console.WriteLine("Digite o seu número de filhos");
                    filhos = Convert.ToInt32(Console.ReadLine());
                    totalFilhos = totalFilhos + filhos;

                    contador++;

                    mediaSalario = totalSalario / contador;
                    mediaFilhos = totalFilhos / contador;
                }
                else
                    break;
            }

            Console.WriteLine("A média de salários da população é: R$" + mediaSalario);
            Console.WriteLine("A média de de filhos da população é: " + mediaFilhos);

            Console.WriteLine("Aperte uma tecla para sair.");
            Console.ReadKey();

        }
    }
}
