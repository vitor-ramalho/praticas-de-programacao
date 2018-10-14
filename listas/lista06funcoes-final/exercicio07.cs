using System;
class Program
{
    static void Main(string[] args)
    {
        int[,] MyArray = new int[12,12];
        int[,] MyArray2 = new int[12,12];
        int[,] MyArray3 = new int[12,12];
        int[,] MyArray4 = new int[12,12];
        int[,] MyArray5 = new int[12,12];
        bool programaAberto = true;
        int opcao;

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                Console.WriteLine("Informe os dados da {0} linha da matriz (12, 12):", i);
                MyArray[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        ExibirArray(MyArray);       
        while(programaAberto == true)
        {
            Console.WriteLine("Escolha a operação que você quer fazer (1 - Troca Linhas 2 e 8 , 2 - Troca Colunas 4 e 10");
            Console.WriteLine("3 - Troca Linha 5 e Coluna 10, 4 - Troca a diagonal primária com a secundária.");
            Console.WriteLine("Aperte qualquer outra tecla para sair do programa.");
            opcao = Convert.ToInt32(Console.ReadLine());
            if (opcao == 1)
            {
                MyArray2 = TrocaLinhas2e8(MyArray);
            }
            else if (opcao == 2)
            {
                MyArray3 = TrocaColuna4e10(MyArray);
            }
            else if (opcao == 3)
            {
                MyArray4 = TrocaLinha5Coluna10(MyArray);
            }
            else if (opcao == 4)
            {
                MyArray5 = TrocaDiagonais(MyArray);
            }
            else
            {
                programaAberto = false;
            }
        }
    }
    static public int[,] TrocaLinhas2e8(int[,] MyArray)
    {
        int[,] MyArrayF = new int[12,12];
        MyArrayF = MyArray;

        for (int i = 0; i < 12; i++)
        {
            MyArrayF[2, i] = MyArray[8, i];
            MyArrayF[8, i] = MyArray[2, i];
        }
        ExibirArray(MyArrayF);
        return MyArrayF;
    }
    static public int[,] TrocaColuna4e10(int[,] MyArray)
    {
        int[,] MyArrayF = new int[12,12];
        MyArrayF = MyArray;

        for (int i = 0; i < 12; i++)
        {
            MyArrayF[i, 4] = MyArray[i, 10];
            MyArrayF[i, 10] = MyArray[i, 4];
        }
        ExibirArray(MyArrayF);
        return MyArrayF;
    }
    static public int[,] TrocaLinha5Coluna10(int[,] MyArray)
    {
        int[,] MyArrayF = new int[12,12];
        MyArrayF = MyArray;

        for (int i = 0; i < 12; i++)
        {
            MyArrayF[5, i] = MyArray[i, 10];
            MyArrayF[i, 10] = MyArray[5, i];
        }
        ExibirArray(MyArrayF);
        return MyArrayF;
    }
    static public int[,] TrocaDiagonais(int[,] MyArray)
    {
        int[,] MyArrayF = new int[12,12];
        MyArrayF = MyArray;

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                MyArrayF[i, j] = MyArray[i, (12 - j)];
                MyArrayF[i, (12 - j)] = MyArray[i, j];
            }
        }
        ExibirArray(MyArrayF);
        return MyArrayF;
    }
    static public void ExibirArray(int[,] MyArray)
    {
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                Console.Write(MyArray[i, j] + " ");
            }
            Console.WriteLine(" ");
        }
    }
}