using System;
using System.Collections.Generic;

namespace Lacorepeticaofor;

class Program
{
    static void Main(string[] args)
    {
        var lista = new List<string>();
        lista.Add("Diouclei");
        lista.Add("Rodrigues");
        lista.Add("Moreira");

        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }
    }
}