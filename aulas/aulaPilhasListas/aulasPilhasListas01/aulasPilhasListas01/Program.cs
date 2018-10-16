using System;
using System.Collections.Generic;

namespace aulasPilhasListas01
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilhaDeStrings = new Stack<string>();
            pilhaDeStrings.Push("Brahma");
            pilhaDeStrings.Push("Skol");
            pilhaDeStrings.Push("Kaiser");

            foreach (string cerveja in pilhaDeStrings)
            {
                Console.WriteLine(cerveja);
            }
            Console.WriteLine("");

            pilhaDeStrings.Pop();

            foreach (string cerveja in pilhaDeStrings)
            {
                Console.WriteLine(cerveja);
            }
            Console.ReadKey();
        }
    }
}
// as PILHAS são como se fosse um 'empilhamento' dos dados. 
// seguem o conceito do LIFO (last in first out), ou seja,
// a primeira a entrar é a ultima a sair da pilha.
// podemos ter uma pilha de qualquer coisa, como int, bool, string, etc.
// utilizamos o metódo push para colocar algo na pilha, e pop para tirar.
// O Pop nao leva nenhum argumento, ele SEMPRE retira o ultimo elemento adicionado.

