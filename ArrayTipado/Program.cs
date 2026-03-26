using System;
using System.Collections.Generic;

namespace ArrayTipado;

class Program
{
    static void Main(string[] args)
    {
        /*
        Random random = new Random();
        var tipado = new int[6];
        for (int i = 0; i < tipado.Length; i++)
        {
            tipado[i] = random.Next(1, 100);
        }
        Console.WriteLine("Valores do array:");
        foreach (var value in tipado)
        {
            Console.WriteLine(value);
        }

        Array.Resize(ref tipado, 6);
        Console.WriteLine("Valores do array após redimensionamento:");
        */
        //Listas 
        var nomes = new List<string>();
        nomes.Add("João");


    }
    //Caso eu preferisse aumentar o tamanho posso usar uma função de redimensionamento
    // como Array.Resize(ref tipado, newSize);
    //Com esta função posso criar um novo array com o tamanho desejado e copiar os valores do array original para o novo array, mantendo os valores existentes.






}


