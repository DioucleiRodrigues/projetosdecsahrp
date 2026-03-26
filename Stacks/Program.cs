using System;
using System.Collections.Generic;

namespace Stacks;

class Program
{
    static void Main(string[] args)
    {
        //Stack, implementada pela lógica de implementação Lifo
        // diferente de uma fila, onde o primeiro a entrar é o primeiro a sair,
        //  na pilha o último a entrar é o primeiro a sair
        // para adicionar itens na pilha, utilizamos o método Push, diferente de queue que usamos o método Enqueue
        // para remover itens da pilha, utilizamos o método Pop, diferente de queue que usamos o método Dequeue
        var stack = new Stack<string>();
        stack.Push("Primeiro item");
        stack.Push("Segundo item");
        stack.Push("Terceiro item");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
        var removendoItem = stack.Pop();
        Console.WriteLine($"Removendo item: {removendoItem}");
        //Lembrando sobre dicionário, onde temos uma chave e um valor, a chave é única e o valor pode ser repetido, diferente de uma lista onde temos apenas valores, no dicionário podemos acessar os valores através da chave, diferente de uma lista onde acessamos os valores através do índice
        /*
        var dicionario = new Dictionary<int, string>();
        dicionario.Add(1, "Diouclei");
        dicionario.Add(2, "Dio");
        dicionario.Add(3, "Dioce");

        foreach (var item in dicionario)
        {
            Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
        }
        */
    }
}