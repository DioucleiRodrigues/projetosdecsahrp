using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
namespace Desafiobasico;

class Program
{
    static void Main(string[] args)
    {
        var tentativas = 0;
        Random numero = new Random();
        var numeroSorteado = numero.Next(1, 100);
        var acertou = false;

        do
        {
            tentativas++;
            Console.WriteLine("Digite um número entre 1 e 100: ");
            var numeroDigitado = int.Parse(Console.ReadLine())!;
            if (numeroDigitado == numeroSorteado)
            {
                Console.WriteLine($"Parabéns! Você acertou o número {numeroSorteado} em {tentativas} tentativas.");
                acertou = true;
                break;
            }
            else if (numeroDigitado < numeroSorteado)
            {
                Console.WriteLine("O número sorteado é maior. Tente novamente.");
            }
            else
            {
                Console.WriteLine("O número sorteado é menor. Tente novamente.");
            }
        }
        while (tentativas < 4);
        Console.WriteLine("");
        if (!acertou)
        {
            Console.WriteLine($"Que pena! O número sorteado era {numeroSorteado}.");
        }
    }
}
