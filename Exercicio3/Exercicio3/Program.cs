using System;
using System.Collections;

namespace Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();

            if (numeros.Count == 0)
            {
                Console.WriteLine("*** Pilha vazia ***");
            }

            numeros.Push(1);
            numeros.Push(2);
            numeros.Push(3);
            numeros.Push(4);
            numeros.Push(5);

            foreach (int numero in numeros)
            {
                Console.WriteLine("Números impressos: " + numero);
            }

            if (numeros.Count == 0)
            {
                Console.WriteLine("*** Pilha vazia ***");
            }

            else
            {
                Console.WriteLine("*** A pilha não está vazia ***");
            }
        }
    }
}