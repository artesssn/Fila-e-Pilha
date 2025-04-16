using System.Collections.Generic;

namespace Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();
            numeros.Push(1);
            numeros.Push(2);
            numeros.Push(3);
            numeros.Push(4);
            numeros.Push(5);

            foreach (int numero in numeros)
            {
                Console.WriteLine("Números impressos: " + numero);
            }
        }
    }
}