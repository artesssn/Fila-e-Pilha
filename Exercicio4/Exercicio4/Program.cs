using System;
using System.Collections.Generic;

namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> nomes = new Queue<string>();

            if (nomes.Count == 0)
            {
                Console.WriteLine("*** Fila vazia ***");
                Console.WriteLine();
            }

            nomes.Enqueue("Ana");
            nomes.Enqueue("Carlos");
            nomes.Enqueue("Beatriz");
            nomes.Enqueue("Daniel");

            foreach (string nome in nomes)
            {
                Console.WriteLine("Nomes impressos: " + nome);
                Console.WriteLine();
            }

            if (nomes.Count == 0)
            {
                Console.WriteLine("*** Fila vazia ***");
            }
            else
            {
                Console.WriteLine("*** A fila não está vazia ***");
            }
        }
    }
}