// até agora, escrevemos todo o nosso código em MAIN, que por si só, já é um metódo.
// metódos são modos de agrupar códigos em um bloco, é basicamente um tipo de ação.
// por exemplo, quando utilizamos console.writeline, utilizamos um metódo, que por trás dele está executando um código.
// dito isso, podemos criar metódos, fazer nossos códigos dentro deles, e reutilizarmos quando necessário.
// obs: FUNÇÕES e METÓDOS são basicamente a mesma coisa.
using System;

namespace exercicio07
{
    class Program
    {
        // metódo main, definido como static, então todo metódo a ser criado dentro dele, para funcionar, terá de ser static.
        // metódos possuem modificadores de acesso, tais como public e private, que definem aonde eles podem ser utilizados.
        static void Main(string[] args)
        {
            DisplayMessage();
            int awnser = Add(5, 10);
            int secondAnwser = Add(awnser, 5); // utilizamos a variável que obtivemos a partir de função e utilizamos como parâmetro.
            Console.WriteLine(secondAnwser);
        }

        // criação do nosso primeiro metódo, primeiro definimos o nível de acesso, PUBLIC, depois especificamos o tipo de valor
        // que nosso resultado irá retornar, VOID, que especifica que o metódo não retorna valor, no caso estamos apenas escrevendo algo.
        // por último, damos um nome ao metódo e, entre () definimos os PARAMETROS que a função receberá, nesse caso, não receberá nenhum.
        public static void DisplayMessage()
        {
            Console.WriteLine("Hello World!");
        }

        // criação de mais um metódo, agora passando parâmetros que a função PRECISA receber, no caso, dois números inteiros.
        // agora, iremos retornar um int, então trocamos void para int.
        // invés de simplesmente printarmos algo, agora RETORNAMOS um valor, o que quer dizer que a função Add SE TORNA um int.
        // a partir disso, podemos armazenar esse resultado em uma variável, por ex. como fizemos acima.
        public static int Add(int number1, int number2)
        {
            int answer = number1 + number2;
            return answer;
        }
    }
}