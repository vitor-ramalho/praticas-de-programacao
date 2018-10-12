using System;

class Program
{
    static void Main(string[] args) 
    {
        int studentGrade = 75;
        GiveExtraCredit(ref studentGrade);
        Console.WriteLine(studentGrade);
    }
    public static void GiveExtraCredit(ref int studentGrade)
    {
        studentGrade +=3;
    }
}

// podemos também forçar que um tipo de valor seja passado como referência.
// assim, podemos mudar o valor da variável studentGrade diretamente.
// para fazer isso, utilizamos a palavra REF, antes da chamada do parâmetro.
// devemos também adicionar REF na chamada do argumento.