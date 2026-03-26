using System;
using System.Collections.Generic;

namespace ProgramacaoOrientadaObjetos;

class Program
{
    static void Main(string[] args)
    {
        /*Trabalhando com classes em C#*/
        var produto = new Cadastro.Product();
        produto.description = "Notebook Dell";
        produto.SetId(15550);
        produto.ShowDescription();

        var pessoa = new Cadastro.Pessoa();
        pessoa.nome = "Diouclei";
        pessoa.idade = 34;
        pessoa.profissao = "Desenvolvedor";
        pessoa.SetCpf(123456789);
        pessoa.ShowInfo();

        double resultado = Cadastro.Calculadora.Dividir(0, 7);
        Console.WriteLine($"Resultado da divisão: {resultado}");


    }
}