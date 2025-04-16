using System;
using System.Collections.Generic;

namespace Filas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> nomes = new Queue<string>();

            nomes.Enqueue("Ana");
            nomes.Enqueue("Carlos");
            nomes.Enqueue("Beatriz");
            nomes.Enqueue("Daniel");

            nomes.Dequeue();

            foreach (string nome in nomes)
            {
                Console.WriteLine("Nomes impressos: " + nome);
            }
        }
    }
}