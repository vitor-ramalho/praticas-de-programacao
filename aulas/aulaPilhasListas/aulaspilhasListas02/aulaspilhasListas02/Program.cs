using System;
using System.Collections.Generic;

namespace aulasPilhasListas01
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> filaDoBanco = new Queue<string>();
            filaDoBanco.Enqueue("Guilherme");
            filaDoBanco.Enqueue("Matheus");
            filaDoBanco.Enqueue("Victor");

            foreach (string pessoa in filaDoBanco)
            {
                Console.WriteLine(pessoa);
            }

            Console.WriteLine("");

            filaDoBanco.Dequeue();

            foreach(string pessoa in filaDoBanco)
            {
                Console.WriteLine(pessoa);
            }

            Console.ReadKey();
        }
    }
}

// FILAS (queues) seguem o conceito de FIRST IN FIRST OUT.
// basicamente, o primeiro a entrar é o primeiro a sair,
// ao contrário das STACKS, onde o primeiro a entrar,
// é o ultimo a sair.
// para adicionar elementos na fila, utilizamos o metódo ENQUEUE
// para retirar elementos da pilha, utilizamos o metódo DEQUEUE
