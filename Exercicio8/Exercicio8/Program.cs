using System;
using System.Collections.Generic;

class Balanceamento
{
    static void Main()
    {
        Console.WriteLine("Digite uma sequência de parênteses: ");

        string entrada = Console.ReadLine();

        Stack<char> pilha = new Stack<char>();

        bool balanceado = true;

        foreach (char parenteses in entrada)
        {
            if (parenteses == '(')
            {
                pilha.Push(parenteses);
            }

            else if (parenteses == ')')
            {
                if (pilha.Count == 0)
                {
                    balanceado = false;
                    break;
                }
                pilha.Pop();
            }
        }

        if (balanceado && pilha.Count == 0)

            Console.WriteLine("Os parênteses estão balanceados");

        else

            Console.WriteLine("Os parênteses não estão balanceados");
    }
}