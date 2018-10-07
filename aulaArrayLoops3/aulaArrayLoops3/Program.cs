using System;

namespace aulaArrayLoops3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Existem alguns metódos úteis para serem utilizados em Arrays.
            // Na aula passada, para procurar um elemento na Array utilizamos uma SEQUENCIAL SEARCH, passando por cada elemento dela.
            int[] myArray = {10, 20, 30, 40, 50 };

            Console.WriteLine("Digite um número para ver se ele existe.");
            int number = int.Parse(Console.ReadLine());
            // Iremos utilizar uma BINARY SEARCH para ver se o elemento está na Array.
            // Quando os números estão em ordem, uma BINARY SEARCH é o modo mais efetivo de procurar um elemento na Array.
            // Esse tipo de procura estipula um midpoint e, dependendo da ordem, procura o número voltando ou avançando na Array.

            int answer = Array.BinarySearch(myArray, number);
            // Executamos a BINARY SEARCH na Array, passando dois argumentos necessários, a Array escolhida (myArray) e o que queremos encontrar (no caso a variável number)
            if(answer < 0)
            {
                Console.WriteLine("O número não existe.");
            }
            else
            {
                Console.WriteLine("A posição do número na Array é {0}", answer);
            }
            // Awnser, caso seja um número encontrado, será sempre 0 ou maior, pois a posição de um número em uma Array será sempre 0 ou maior.
            // Então, fazemos a condicional, caso answer < 0 ou não.

            int[] myArray2 = { 10, 5, 7, 2, 55 };
            // Quanto temos uma Array aleatória, como a Array acima, podemos ordená-la utilizando o metódo Sort.
            Array.Sort(myArray2);
            for (int i = 0; i < myArray2.Length; i++)
            {
                Console.WriteLine(myArray2[i]);
            }

            int[] myArray3 = { 10, 5, 7, 2, 55 };
            // Com o metódo Reverse, conseguimos inverter a ordem de uma Array, ou seja, ela irá começar do 55.

            Array.Reverse(myArray3);
            for (int i = 0; i < myArray3.Length; i++)
            {
                Console.WriteLine(myArray3[i]);
            }
            Console.ReadKey();
        }
    }
}
