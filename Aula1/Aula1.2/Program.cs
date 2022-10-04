using System;

namespace Aula1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, n1, n2, n3, mult;
            Console.WriteLine("Digite o primeiro valor:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("os dois primeiros valores são: " +b + "e" +a );
           
            Console.WriteLine("Digite um valor:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um segundo valor:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um terceiro valor:");
            n3 = int.Parse(Console.ReadLine());
            mult = n1 * n2 * n3;
            Console.WriteLine("Multiplicação dos valores igual a: " + mult);







        }
    }
}
