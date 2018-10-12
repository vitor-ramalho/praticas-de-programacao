using System;

// quando falamos em passar algo para a função, falamos em prover informação para ela, via parâmetros.
// agora, vamos falar sobre a diferença entre passar via referência (PASS BY REFERENCE) e passar via valor
// (PASS BY VALUE).
class Program
{
    static void Main(string[] args)
    {
        // PASS BY VALUE (passando parâmetros por tipos de valor)
        int student1grade = 75;
        Console.WriteLine("Students grade before extra credit (pass by value): {0}", student1grade);
        GiveExtraCredit(student1grade);
        Console.WriteLine("Students grade after extra credit: (pass by value) {0}", student1grade);

        // PASS BY REFERENCE (passando parâmetros por tipos de referência)
        int[] grades = new int[1];
        grades[0] = 75;
        Console.WriteLine("Students grade before extra credit: (pass by reference) {0}", grades[0]);
        GiveExtraCreditArray(grades);
        Console.WriteLine("Students grade before after credit: (pass by reference) {0}", grades[0]);
    }

    // função que recebe um int por parâmetro.
    public static void GiveExtraCredit(int studentsGrade)
    {
        studentsGrade+=3;
    }

    // função que recebe uma array por parâmetro.
    public static void GiveExtraCreditArray(int[] grades)
    {
        grades[0] += 3;
    }
}
// 1
// aqui, passamos a variável student1grade (75) como valor, isso acontece porque a variável é do tipo int.
// variáveis do tipo int, bool, double, bool, etc, são STRUCS, consideradas TIPOS DE VALOR, e são sempre passadas como valor.
// ao passarmos como valor, passamos apenas uma CÓPIA da variável para o PARÂMETRO da função, ou seja,
// a variável stundent1grade NÃO SERÁ afetada pela função GiveExtraCredit.
// por isso, ao escrevermos console.writeline antes e após a execução da função, os dois retornam 75,
// que é o valor da variável original, pois a função não trocou seu valor original.

// 2 
// agora, criamos a array grades, arrays são TIPOS DE REFERÊNCIA, isso acontece porque int[] é uma CLASSE,
// e toda classe é um TIPO DE REFERÊNCIA. o que faz dessa classe realmente um tipo de referência é a
// palavra NEW, que é o operador utilizado para criar classes.
// quando passamos por referência, como acontece com a array, nos passamos a localização exata da variável
// para a função, fazendo com que ela seja mudada diretamente.