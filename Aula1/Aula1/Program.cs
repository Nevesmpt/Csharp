using System;

namespace Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x;
            int a, b, soma;
            Console.WriteLine("Hello");
            Console.WriteLine("Manuel");
            
            Console.WriteLine("Soma de dois valores:");
            Console.WriteLine("Digite o primeiro valor:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            b = int.Parse(Console.ReadLine());
            soma = a + b;
            Console.WriteLine("O valor da soma é: " + soma);
            
            Console.WriteLine("Digite um número");
            x = Console.ReadLine();
            Console.WriteLine("O número é: " + x);





        }
    }
}
