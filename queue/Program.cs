using System;
using System.Collections.Generic;

namespace Queued;

class Program
{
    static void Main(string[] args)
    {
        //Utiliza do conceito de fila, onde o primeiro elemento a entrar é o primeiro a sair (FIFO - First In, First Out)
        //Não possui o método add, mas sim o Enqueue, que seria empilhar um elemento na fila
        //Não possui o método remove, mas sim o Dequeue, que seria desempilhar um elemento da fila
        //Não possui o método peek, mas sim o Peek, que seria espiar o próximo elemento da fila
        //Não se pode acessar um elemento específico da fila, apenas o próximo elemento a ser desempilhado
        var fila = new Queue<string>();
        fila.Enqueue("Diouclei");
        fila.Enqueue("Giullia");
        fila.Enqueue("Herica");
        fila.Enqueue("Gamora");
        Console.WriteLine(fila.Peek()); //Diouclei, espiando elemento próximo a ser desempilhado
        Console.WriteLine(fila.Dequeue()); //Diouclei, desempilhando elemento
        fila.Enqueue("Diouclei");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Percorrendo o Queue com foreach");
        foreach (var item in fila)
        {
            Console.WriteLine(item);
        }
    }
}