using System;
using System.Collections.Generic;

namespace Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra;

            Stack<char> pilha = new Stack<char>();

            Console.WriteLine("Escreva uma palavra:");
            palavra = Console.ReadLine();

            foreach (char letra in palavra)
            {
                pilha.Push(letra);
            }

            string palavraInvertida = "";

            while (pilha.Count > 0)
            {
                palavraInvertida += pilha.Pop();
            }

            Console.WriteLine("A palavra invertida fica: " + palavraInvertida);
        }
    }
}