using System;

namespace exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, nota, faltas, media, alunos90, alunosReprovados, totalNotas, maiorNota, menorNota;

            nota = 0;
            alunos90 = 0;
            alunosReprovados = 0;
            i = 0;
            totalNotas = 0;
            maiorNota = 0;
            menorNota = 100;


            while (nota >= 0)
            {
                i++;

                Console.WriteLine("Digite a nota final: ");
                nota = Convert.ToInt32(Console.ReadLine());

                if (nota > maiorNota && nota > menorNota)
                {
                    maiorNota = nota;
                    menorNota = menorNota + 0;
                }
                else if (maiorNota > nota && nota > menorNota)
                {
                    maiorNota = maiorNota + 0;
                    menorNota = menorNota + 0;
                }
                else if (nota > maiorNota && menorNota > nota)
                {
                    maiorNota = nota;
                    menorNota = nota;
                }
                else if (maiorNota > nota && menorNota > nota)
                {
                    maiorNota = maiorNota + 0;
                    menorNota = nota;
                }

                if (nota >= 0)
                {
                    Console.WriteLine("Digite o total de faltas: ");
                    faltas = Convert.ToInt32(Console.ReadLine());

                    if (nota >= 90 && faltas <= 20)
                    {
                        alunos90++;
                    }
                    else if (nota >= 90 && faltas > 20)
                    {
                        alunos90++;
                        alunosReprovados++;
                    }
                    else if (nota < 70 || faltas >= 20)
                    {
                        alunosReprovados++;
                    }

                    totalNotas = totalNotas + nota;
                    media = totalNotas / i;

                    Console.WriteLine("A quantidade de alunos com nota maior ou igual a 90 é: " + alunos90);
                    Console.WriteLine("A quantidade de alunos reprovados é: " + alunosReprovados);
                    Console.WriteLine("A média de notas da turma é: " + media);
                    Console.WriteLine("A maior nota da turma é: " + maiorNota);
                    Console.WriteLine("A menor nota da turma é: " + menorNota);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Pressione uma tecla para sair");
            Console.ReadKey();
        }
    }
}
