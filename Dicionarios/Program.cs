//Num dicionário passamos dois valores
//Um para a chave e outro para o valor
//O valor pode ser de qualquer tipo, inclusive outro dicionário
using System;
using System.Collections.Generic;

namespace Dicionarios;

class Program
{
    static void Main(string[] args)
    {
        var nome = new List<string>();
        var dicionario = new Dictionary<int, string>();
        dicionario.Add(1, "Diouclei");
        dicionario.Add(2, "Giullia");
        dicionario.Add(3, "Gustavo");
        dicionario.Add(4, "Gusto");
        nome.Add(dicionario[1]);
        // Console.WriteLine(nome[0]);
        //Console.WriteLine(dicionario[2]);

        foreach (var item in dicionario)
        {
            Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
        }
    }
}