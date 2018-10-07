using System;

namespace aulaArrayLoops2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Bob", "Ted", "Tom", "Fred" };
            // Primeiro, estamos criando uma Array básica de estudantes, composta por strings que são os nomes de cada um.
            // Queremos um modo através do qual possamos descobrir se um nome específico de um aluno está dentro da Array.
            int[] grades = { 77, 50, 78, 99 };
            // Temos uma outra Array, que se refere às notas de cada aluno, ou seja, esse é o conceito de PARALLEL ARRAY.
            // Arrays parelas são Arrays que se equivalem, elas tem a mesma length. Aqui, por exemplo, no index [0] temos "Bob" e sua nota 77.

            Console.WriteLine("Enter student name to search for");
            string studentsName = Console.ReadLine();
            bool contains = false;
            int studentGrade = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (studentsName == students[i])
                {
                    contains = true;
                    studentGrade = grades[i];
                    break;
                }
            }
            // Com esse Loop, percorremos a Array e, caso o nome digitado seja igual à algum elemento da Array, contains se torna true.
            // Além disso, criamos a variável studentGrade, que será igual ao número da posição [i] do Loop dentro da Array de Grades.

            if (contains == true)
            {
                Console.WriteLine("O estudante está nessa classe.");
                Console.WriteLine("A nota do estudante é igual a {0}", studentGrade);
            }
            else
            {
                Console.WriteLine("O estudante não está na classe.");
            }
            // Aqui fazemos uma condicional simples, se contains for true, retornamos que ele está na classe.

            Console.WriteLine("Digite uma tecla para sair.");
            Console.ReadKey();
        }
    }
}
