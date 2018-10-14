using System;

class Program
{
    static void Main(string[] args)
    {
        int opcao;
        bool programaAberto = true;
        string[] nomes = new string[15];
        double[] alturas = new double[15];

        while(programaAberto == true)
        {   
            Console.WriteLine("Digite 1 para incluir 15 pessoas e suas alturas.");
            Console.WriteLine("Digite 2 para ver as pessoas com menos de 1,50m.");
            Console.WriteLine("Digite 3 para ver as pessoas com mais de 1,50m.");
            Console.WriteLine("Digite 4 para ver todas as pessoas e sua média de altura.");
            opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                Cadastrar(alturas, nomes);
            }
            else if (opcao == 2)
            {
                PessoasMenores(alturas, nomes);
            }
            else if (opcao == 3)
            {
                PessoasMaiores(alturas, nomes);
            }
            else if (opcao == 4)
            {
                Media(alturas, nomes);
            }

            Console.WriteLine("Deseja fechar o programa? Digite 0 para fechar, qualquer outro número para continuar.");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 0)
            {
                programaAberto = false;
            }
            else 
            {
                programaAberto = true;
            }
        }
    }
    public static void Cadastrar(double[] alturas, string[] nomes)
    {
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine("Digite o nome da pessoa:");
            nomes[i] = Console.ReadLine();
            Console.WriteLine("Digite a altura da pessoa (com virgula):");
            alturas[i] = Convert.ToDouble(Console.ReadLine());
        }
    }

    public static void PessoasMenores(double[] alturas, string[] nomes)
    {
        for (int i = 0; i < 15; i++)
        {
            if (alturas[i] < 1.50)
            {
                Console.WriteLine("Nome: {0}, Altura: {1}m", nomes[i], alturas[i]);
            }
        }
        Console.WriteLine("");
    }
    public static void PessoasMaiores(double[] alturas, string[] nomes)
    {
        for (int i = 0; i < 15; i++)
        {
            if (alturas[i] > 1.50)
            {
                Console.WriteLine("Nome: {0}, Altura: {1}m", nomes[i], alturas[i]);
            }
        }
        Console.WriteLine("");
    }
    public static void Media(double[] alturas, string[] nomes)
    {
        double total = 0;
        for (int i = 0; i < 15; i++)
        {
            total = total + alturas[i];
            Console.WriteLine("Nome: {0}, Altura: {1}m", nomes[i], alturas[i]);
        }
        double media = total / 15;
        Console.WriteLine("A média de altura entre as pessoas é {0}.", media);
        Console.WriteLine("");        
    }

}