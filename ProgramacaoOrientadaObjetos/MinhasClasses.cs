using System.Runtime.CompilerServices;

namespace Cadastro
{
    /*Classes que não são do tipo Static precisam ser instanciadas*/
    public class Product
    {
        private int Id;
        public string description { get; set; }
        public void ShowDescription()
        {
            Console.WriteLine($"Código do produto: {GetId()}, Descrição do produto: {description}");
        }
        public void SetId(int id)
        {
            Id = id;
        }
        public int GetId()
        {
            return Id;
        }
    }

    public class Pessoa
    {
        private int Cpf;
        public string nome { get; set; }
        public int idade { get; set; }
        public string profissao { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine("Informações da pessoa:");
            Console.WriteLine($"Nome: {nome}, Idade: {idade}, Profissão: {profissao}, CPF: {GetCpf()}");
        }
        public void SetCpf(int cpf)
        {
            Cpf = cpf;
        }
        public int GetCpf()
        {
            return Cpf;
        }
    }

    /**Classes do tipo Static não precisam ser instanciadas, ou seja, não é necessário criar um objeto para acessar seus membros. Elas são usadas para agrupar métodos e propriedades que não dependem de uma instância específica da classe. Os membros de uma classe estática 
    são acessados diretamente através do nome da classe, sem a necessidade de criar um objeto.*/
    public static class Calculadora
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }
        public static int Subtrair(int a, int b)
        {
            return a - b;
        }
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public static double Dividir(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
                return 0;
            }
            return (double)a / b;
        }
    }
}


