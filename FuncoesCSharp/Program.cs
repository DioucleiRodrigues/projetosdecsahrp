using System;
using System.Collections;


namespace FuncoesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string nome = NomeCompleto();
            Console.WriteLine(nome);

            int resultado = Somar(5, 10);
            Console.WriteLine(resultado);
             string NomeCompleto()
            {
                return "Diouclei Rodrigues";
            }
        }
        static int Somar(int a, int b)
        {
            return a + b;
        }*/
            //Array List
            var lista = new ArrayList();
            lista.Add("Diouclei");
            lista.Add("Rodrigues");
            lista.Add(30);
            lista.Add(0);
            /*
            for (int i = 1; i <= lista.Count; i++)
            {
                Console.WriteLine(lista[i - 1]);
                Thread.Sleep(1000);
            }*/

            //Removendo itens da lista

            lista.RemoveAt(3);
            lista.Clear();
            /*
            foreach (var item in lista)
            {
                Console.WriteLine(item);
                System.Threading.Thread.Sleep(1000);

            }
            */
            //Gerando números aleatórios
            Random aleatorio = new Random();
            for (int i = 0; i < 20; i++)
            {
                lista.Add(aleatorio.Next(1, 100));
            }
            foreach (var item in lista)
            {
                Console.WriteLine(item);
                System.Threading.Thread.Sleep(1000);

            }
        }
    }
}