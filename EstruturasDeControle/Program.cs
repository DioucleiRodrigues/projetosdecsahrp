using System;
using System.Collections.Generic;
namespace EstruturasDeControle;

class Program
{
    static void Main(string[] args)
    {
        // Estruturas de controle IF ELSE
        /*
        Console.WriteLine("Ola informe o dia da semana");
        var dia = new Dictionary<string, string>();
        dia.Add("1", "Domingo");
        dia.Add("2", "Segunda");
        dia.Add("3", "Terça");
        dia.Add("4", "Quarta");
        dia.Add("5", "Quinta");
        dia.Add("6", "Sexta");
        dia.Add("7", "Sábado");

        foreach (var key in dia)
        {
            Console.WriteLine($"Opção {key.Key} - {key.Value}");
        }

        Console.WriteLine("");
        Console.WriteLine("Informe o numero do dia da semana");
        var numero = Console.ReadLine() ?? " ";//Fazendo um tratamento para caso o usuario
        //  não digite nada, evitando um erro de null reference

        Console.WriteLine("O dia da semana escolhido foi " + dia[numero]);
        */

        //Estrutura de controle Switch Case
        Console.WriteLine("Ola informe o dia da semana");
        var dia = new Dictionary<string, string>();
        dia.Add("1", "Domingo");
        dia.Add("2", "Segunda");
        dia.Add("3", "Terça");
        dia.Add("4", "Quarta");
        dia.Add("5", "Quinta");
        dia.Add("6", "Sexta");
        dia.Add("7", "Sábado");

        foreach (var key in dia)
        {
            Console.WriteLine($"Opção {key.Key} - {key.Value}");
        }

        Console.WriteLine("");
        Console.WriteLine("Informe o numero do dia da semana");
        var numero = Console.ReadLine() ?? " ";//Fazendo um tratamento para caso o usuario
        //  não digite nada, evitando um erro de null reference

        switch (numero)
        {
            case "1":
                Console.WriteLine("O dia da semana escolhido foi Domingo");
                break;
            case "2":
                Console.WriteLine("O day da semana escolhido foi Segunda-feira");
                break;
            case "3":
                Console.WriteLine("O day da semana escolhido foi Terça-feira");
                break;
            case "4":
                Console.WriteLine("O day da semana escolhido foi Quarta-feira");
                break;
            case "5":
                Console.WriteLine("O day da semana escolhido foi Quinta-feira");
                break;
            case "6":
                Console.WriteLine("O day da semana escolhido foi Sexta-feira");
                break;
            case "7":
                Console.WriteLine("O day da semana escolhido foi Sábado");
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
}
