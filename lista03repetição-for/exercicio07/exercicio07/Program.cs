using System;

namespace exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int voto;
            int votosBolsonaro = 0;
            int votosHaddad = 0;
            int votosDaciolo = 0;
            int votosBranco = 0;
            int votosNulo = 0;

            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine("Digite em qual candidato você irá votar (51 para Daciolo, 17 para Bolsonaro " +
                "e 13 para Haddad, 0 para Branco e qualquer outro número para Nulo):");
                voto = Convert.ToInt32(Console.ReadLine());

                if (voto == 17)
                {
                    votosBolsonaro++;
                }
                else if (voto == 51)
                {
                    votosDaciolo++;
                }
                else if (voto == 13)
                {
                    votosHaddad++;
                }
                else if (voto == 0)
                {
                    votosBranco++;
                }
                else
                {
                    votosNulo++;
                }

                Console.WriteLine("O número de pessoas que votaram no Bolsonaro é: " + votosBolsonaro);
                Console.WriteLine("O número de pessoas que votaram no Haddad é: " + votosHaddad);
                Console.WriteLine("O número de pessoas que votaram no Daciolo é: " + votosDaciolo);
                Console.WriteLine("A porcentagem de pessoas que votaram no Bolsonaro é de: " + (votosBolsonaro / i));
                Console.WriteLine("A porcentagem de pessoas que votaram no Haddad é de: " + (votosHaddad / i));
                Console.WriteLine("A porcentagem de pessoas que votaram no Daciolo é de: " + (votosDaciolo / i));
                Console.WriteLine("A porcentagem de pessoas que votaram nulo é de: " + (votosNulo / i));
                Console.WriteLine("A porcentagem de pessoas que votaram branco é de: " + (votosBranco / i));

            }
        }
    }
}
