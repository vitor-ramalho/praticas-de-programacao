using System;

namespace aulaArrayLoops4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Até agora, trabalhamos apenas com arrays de uma dimensão (uma linha horizontal).
            int[] myArray = { 5, 6, 7 }; // Array de uma dimensão.

            // Agora, trabalharemos com Arrays com mais de uma dimensão, ou seja, com colunas e linhas, como se fosse um grid.
            // Arrays multidimensionais podem ficar bem confusas, então aqui daremos apenas uma breve olhada nelas.
            // O primeiro tipo de array multidimensional é a RETANGULAR: Cada linha tem o mesmo número de colunas.
            // O segundo tipo é a IRREGULAR (jagged): As linhas podem ter diferentes números de colunas.
            // Uma Jagged Array é uma Array de Arrays, cada dimensão dela é uma Array diferente que a forma.
            int[,] myArray2 = new int[3, 4]; //Array de duas dimensões, com 3 linhas e 4 colunas.
            myArray2[0, 0] = 5;
            myArray2[0, 1] = 6;
            myArray2[0, 2] = 7;
            myArray2[0, 3] = 8; 

            myArray2[1, 0] = 5;
            myArray2[1, 1] = 6;
            myArray2[1, 2] = 7;
            myArray2[1, 3] = 8;

            myArray2[2, 0] = 5;
            myArray2[2, 1] = 6;
            myArray2[2, 2] = 7;
            myArray2[2, 3] = 8; // Atribuição de números para a primeira linha da Array multidimensional que criamos.

            int[,] myArray3 = { {5, 6, 7, 8},
                                {5, 6, 7, 8 },
                                {5, 6, 7, 8 }, // Dessa forma, criamos uma Array multidimensional já atribuindo os valores, de uma forma "shorthand".
                              };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(myArray2[i, j]);
                }
                Console.WriteLine();
            } // Fazemos um loop dentro de um loop, para obtermos os valores de cada dimensão da Array e exibirmos para o usuário.

            int[][] myArray4 = new int[3][]; // Criação de uma Jagged Array, definimos o número de linhas que ela irá ter, o número de colunas não é necessário.
            myArray4[0] = new int[4] { 5, 6, 7, 8 };
            myArray4[1] = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            myArray4[2] = new int[2]  {6, 7 }; // Como cada linha de uma Jagged Array é uma nova Array, definimos o número de colunas para cada linha (array) nova.

            for ( int i = 0; i < 3; i++)
            {
                for (int j = 0; j < myArray4[i].Length; j++)
                {
                    Console.Write(myArray4[i][j]);
                }
                Console.WriteLine();
            } // Para exibirmos cada valor de uma Jagged Array, fazemos loops parecidos com os de uma Array Retangular.
              // Porém, neste caso, como os valores de colunas são diferentes para cada linha, precisamos informar isso no loop.

            Console.ReadKey();
        }
    }
}
