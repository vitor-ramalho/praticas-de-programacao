using System;

namespace aulaArraysLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 66, 88, 95, 90, 100 };
            // Array de 5 elementos, contendo a nota de cinco estudantes.
            // Queremos dar aos alunos 3 pontos extras para cada um, como faremos isso?
            // 1 - Metódo sem loops:
            /* 
            grades[0] += 3;
            grades[1] += 3;
            grades[2] += 3;
            grades[3] += 3;
            grades[4] += 3;
            */

            // Mas se tivessemos 50 estudantes isso seria um inferno, não é mesmo?
            for(int i = 0; i < grades.Length; i++)
            {
                grades[i] += 3;
                Console.WriteLine(grades[i]);
            }
            // Com esse código, adicionamos mais 3 na nota de cada aluno e exibimos para o usuário as notas, utilizando apenas duas linhas no loop.
            // O grades.Length faz com que não tenhamos que nos preocupar em reajustar o Loop conforme adicionarmos novas notas.

            // Podemos usar também um novo tipo de Loop, chamado FOR EACH Loop, utilizado para trabalhar com grandes tipos de dados.
            foreach(int score in grades)
            {
                Console.WriteLine(score);
            }
            // Porém, não podemos adicionar mais 3 nas notas de cada aluno, porque o valor de cada score que definimos aqui é READ ONLY.
            // O FOR EACH Loop é utilizado, de forma geral, para mostrar valores e obter valores em Arrays.

            Console.WriteLine("Pressione uma tecla para sair.");
            Console.ReadKey();
        }
    }
}
