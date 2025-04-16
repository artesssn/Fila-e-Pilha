using System;
using System.Collections.Generic;

namespace BinarioParaDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pilha = new Stack<int>();

            Console.WriteLine("Digite um número decimal: ");
            int numeroDecimal = int.Parse(Console.ReadLine());


            Console.WriteLine("Número binário: ");

            while (numeroDecimal > 0)
            {
                int resto = numeroDecimal % 2;
                pilha.Push(resto);
                numeroDecimal /= 2;
            }

            while (pilha.Count > 0)
            {
                Console.WriteLine(pilha.Pop());
            }

            Console.WriteLine();
        }
    }
}